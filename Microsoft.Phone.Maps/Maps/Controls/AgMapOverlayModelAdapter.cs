// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.AgMapOverlayModelAdapter
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Device.Location;
using System.Runtime.InteropServices;
using System.Windows;

namespace Microsoft.Phone.Maps.Controls
{
  internal class AgMapOverlayModelAdapter : IDisposable
  {
    private bool disposed;
    private AgMapOverlayModelSafeHandle nativeAdapter;
    private GeoCoordinate geoCoordinateInternal;
    private Point centerInternal;

    ~AgMapOverlayModelAdapter() => this.Dispose(false);

    public GeoCoordinate GeoCoordinate
    {
      get => this.geoCoordinateInternal;
      set
      {
        if (this.nativeAdapter != null)
          Marshal.ThrowExceptionForHR(Shim.AgMapOverlayModelAdapter_SetCoordinate(this.nativeAdapter, value.Latitude, value.Longitude));
        this.geoCoordinateInternal = value;
      }
    }

    public Point Center
    {
      get => this.centerInternal;
      set
      {
        if (this.nativeAdapter != null)
          Marshal.ThrowExceptionForHR(Shim.AgMapOverlayModelAdapter_SetCenter(this.nativeAdapter, checked ((int) value.X), checked ((int) value.Y)));
        this.centerInternal = value;
      }
    }

    public AgMapOverlayModelSafeHandle Handle
    {
      get => this.nativeAdapter;
      set
      {
        this.nativeAdapter = value;
        Point center = this.Center;
        this.Center = this.centerInternal;
        if (!(this.geoCoordinateInternal != (GeoCoordinate) null))
          return;
        this.GeoCoordinate = this.geoCoordinateInternal;
      }
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    protected void Dispose(bool disposing)
    {
      if (!this.disposed && disposing && (this.nativeAdapter != null && !this.nativeAdapter.IsInvalid))
      {
        this.nativeAdapter.Dispose();
        this.nativeAdapter = (AgMapOverlayModelSafeHandle) null;
      }
      this.disposed = true;
    }
  }
}
