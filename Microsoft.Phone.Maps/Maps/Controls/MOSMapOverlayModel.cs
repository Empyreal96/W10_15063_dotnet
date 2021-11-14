// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MOSMapOverlayModel
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Device.Location;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Windows;

namespace Microsoft.Phone.Maps.Controls
{
  internal class MOSMapOverlayModel : IMapOverlayModel
  {
    private bool disposed;
    private AgMapOverlayModelAdapter nativeAdapter;
    private Point? positionOrigin;

    public MOSMapOverlayModel() => this.nativeAdapter = new AgMapOverlayModelAdapter();

    ~MOSMapOverlayModel() => this.Dispose(false);

    public Point PositionOrigin
    {
      get
      {
        if (!this.positionOrigin.HasValue)
          this.positionOrigin = new Point?(new Point(DipHelper.ConvertScreenToDipPixel(this.nativeAdapter.Center.X), DipHelper.ConvertScreenToDipPixel(this.nativeAdapter.Center.Y)));
        return this.positionOrigin.Value;
      }
      set
      {
        this.positionOrigin = new Point?(value);
        this.nativeAdapter.Center = new Point(DipHelper.ConvertDipToScreenPixel(value.X), DipHelper.ConvertDipToScreenPixel(value.Y));
      }
    }

    public GeoCoordinate GeoCoordinate
    {
      get => this.nativeAdapter.GeoCoordinate;
      set => this.nativeAdapter.GeoCoordinate = value;
    }

    public SafeHandle AnimationHandle { get; set; }

    public IMapModel MapModel { get; set; }

    public SafeHandle Handle
    {
      get => (SafeHandle) this.nativeAdapter.Handle;
      set => this.nativeAdapter.Handle = (AgMapOverlayModelSafeHandle) value;
    }

    public void OnEnterVisualTree() => this.MapModel.AddMapOverlay((IMapOverlayModel) this);

    public void OnLeavingVisual() => this.MapModel.RemoveMapOverlay((IMapOverlayModel) this);

    [SuppressMessage("Microsoft.Usage", "CA1816:CallGCSuppressFinalizeCorrectly", Justification = "GC.SuppressFinalize is being called deliberately")]
    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    protected void Dispose(bool disposing)
    {
      if (!this.disposed && disposing && (this.nativeAdapter != null && !this.nativeAdapter.Handle.IsInvalid))
      {
        this.nativeAdapter.Dispose();
        this.nativeAdapter = (AgMapOverlayModelAdapter) null;
      }
      this.disposed = true;
    }
  }
}
