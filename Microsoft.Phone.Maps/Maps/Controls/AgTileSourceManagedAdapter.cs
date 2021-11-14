// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.AgTileSourceManagedAdapter
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Maps.Controls
{
  internal class AgTileSourceManagedAdapter : IDisposable
  {
    private readonly AgTileSourceSafeHandle nativeAdapter;
    private static bool reverseCallbacksInitialized;
    private bool disposed;

    public AgTileSourceManagedAdapter()
    {
      Marshal.ThrowExceptionForHR(Shim.AgTileSourceAdapter_Create(out this.nativeAdapter));
      if (this.nativeAdapter.IsInvalid)
        throw new InvalidOperationException(Resources.CreationException);
    }

    ~AgTileSourceManagedAdapter() => this.Dispose(false);

    public static TileSourceReverseCallbackDelegates.GetUriCallback ReverseCallbacks
    {
      set
      {
        if (AgTileSourceManagedAdapter.reverseCallbacksInitialized)
          return;
        Marshal.ThrowExceptionForHR(Shim.AgTileSourceAdapter_SetTileSourceReverseCallbacks(value));
        AgTileSourceManagedAdapter.reverseCallbacksInitialized = true;
      }
    }

    public AgTileSourceSafeHandle NativeAdapter => this.nativeAdapter;

    public int Id => Shim.AgTileSourceAdapter_GetInstanceId(this.nativeAdapter);

    public Range<int> ZoomRange
    {
      get
      {
        int fromZoomLevel;
        int toZoomLevel;
        Marshal.ThrowExceptionForHR(Shim.AgTileSourceAdapter_GetZoomRange(this.nativeAdapter, out fromZoomLevel, out toZoomLevel));
        return new Range<int>(fromZoomLevel, toZoomLevel);
      }
      set => Marshal.ThrowExceptionForHR(Shim.AgTileSourceAdapter_SetZoomRange(this.nativeAdapter, value.From, value.To));
    }

    public MarshaledBoundingRectangle BoundingRectangle
    {
      get
      {
        MarshaledBoundingRectangle boundingRectangle;
        Marshal.ThrowExceptionForHR(Shim.AgTileSourceAdapter_GetBoundingRectangle(this.nativeAdapter, out boundingRectangle));
        return boundingRectangle;
      }
      set => Marshal.ThrowExceptionForHR(Shim.AgTileSourceAdapter_SetBoundingRectangle(this.nativeAdapter, value));
    }

    public void SetUri(IntPtr buffer, string uri)
    {
      if (string.IsNullOrEmpty(uri))
        return;
      Marshal.ThrowExceptionForHR(Shim.AgTileSourceAdapter_SetUri(buffer, uri));
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
      if (disposing && this.nativeAdapter != null && !this.nativeAdapter.IsInvalid)
        this.nativeAdapter.Dispose();
      this.disposed = true;
    }
  }
}
