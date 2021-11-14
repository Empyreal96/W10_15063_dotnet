// Decompiled with JetBrains decompiler
// Type: LocationServiceInterop.ILocationManager
// Assembly: LocationService.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 0F7FF74F-5B20-469A-BF3F-5B3C20DFBAEC
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\LOCATI~3.DLL

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LocationServiceInterop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComConversionLoss]
  [Guid("3D0423B1-BBD4-4C4A-8F20-DA15228E0F3D")]
  [ComImport]
  public interface ILocationManager
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CallerCanGetPosition();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs((UnmanagedType) 28)]
    ILocationSession GetLocationSession([In] LOCATIONREQUEST LOCATIONREQUEST);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs((UnmanagedType) 28)]
    IGeofenceAppBoundary GetGeofenceAppBoundary();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetLocationHistory(
      [In] _FILETIME StartTime,
      [In] long DurationInMilliseconds,
      out uint pLocationReadingsCount,
      [Out] IntPtr ppLocationReading);

    [DispId(1610678276)]
    IntPtr DefaultLocation { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(1610678278)]
    int IsDefaultLocationRecommended { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CallerCanGetConsentlessPosition();
  }
}
