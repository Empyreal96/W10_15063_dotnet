// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MOSTileSource
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;

namespace Microsoft.Phone.Maps.Controls
{
  internal class MOSTileSource : ITileSourceModel, IDisposable
  {
    private readonly AgTileSourceManagedAdapter adapter;
    private static readonly Range<int> allZoomRange = new Range<int>(0, 20);
    private static readonly LocationRectangle allLocationRectangle = new LocationRectangle(90.0, -180.0, -90.0, 179.999);
    private bool disposed;

    public MOSTileSource(TileSourceCallbacks tileSourceCallbacks)
    {
      this.TileSourceCallbacks = tileSourceCallbacks;
      AgTileSourceManagedAdapter.ReverseCallbacks = TileSourceReverseCallbacksThunk.GetUriEventHandler;
      this.adapter = new AgTileSourceManagedAdapter();
      this.Id = this.adapter.Id;
      TileSourceReverseCallbacksThunk.TileSourceInstanceRegistry.Insert(this.Id, (ITileSourceModel) this);
      this.IsInRegistry = true;
    }

    ~MOSTileSource() => this.Dispose(false);

    public AgTileSourceSafeHandle NativeAdapter => this.adapter.NativeAdapter;

    public TileSourceCallbacks TileSourceCallbacks { get; set; }

    public int Id { get; private set; }

    public bool IsInRegistry { get; private set; }

    public Range<int> ZoomRange
    {
      get => this.adapter.ZoomRange;
      set
      {
        if (value == null)
          value = MOSTileSource.allZoomRange;
        this.adapter.ZoomRange = value;
      }
    }

    public LocationRectangle BoundingRectangle
    {
      get => MarshaledTypeConverter.ToLocationRectangle(this.adapter.BoundingRectangle);
      set
      {
        if (value == null)
          value = MOSTileSource.allLocationRectangle;
        this.adapter.BoundingRectangle = MarshaledTypeConverter.ToMarshaledBoundingRectangle(value);
      }
    }

    public void OnGetUriDone(IntPtr state, Uri uri)
    {
      if (!(uri != (Uri) null))
        return;
      this.adapter.SetUri(state, uri.ToString());
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    protected void Dispose(bool disposing)
    {
      if (this.disposed)
        return;
      if (this.IsInRegistry)
      {
        TileSourceReverseCallbacksThunk.TileSourceInstanceRegistry.Remove(this.Id);
        this.IsInRegistry = false;
      }
      if (disposing && this.adapter != null)
        this.adapter.Dispose();
      this.disposed = true;
    }
  }
}
