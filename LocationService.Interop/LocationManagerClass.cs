// Decompiled with JetBrains decompiler
// Type: LocationServiceInterop.LocationManagerClass
// Assembly: LocationService.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 0F7FF74F-5B20-469A-BF3F-5B3C20DFBAEC
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\LOCATI~3.DLL

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LocationServiceInterop
{
  [ComConversionLoss]
  [Guid("08D9DFDF-C6F7-404A-A20F-66EEC0A609CD")]
  [ClassInterface(ClassInterfaceType.None)]
  [TypeLibType]
  [ComImport]
  public class LocationManagerClass : ILocationManager, LocationManager
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern LocationManagerClass();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void CallerCanGetPosition();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs((UnmanagedType) 28)]
    public virtual extern ILocationSession GetLocationSession(
      [In] LOCATIONREQUEST LOCATIONREQUEST);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs((UnmanagedType) 28)]
    public virtual extern IGeofenceAppBoundary GetGeofenceAppBoundary();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void GetLocationHistory(
      [In] _FILETIME StartTime,
      [In] long DurationInMilliseconds,
      out uint pLocationReadingsCount,
      [Out] IntPtr ppLocationReading);

    [DispId(1610678276)]
    public virtual extern IntPtr DefaultLocation { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(1610678278)]
    public virtual extern int IsDefaultLocationRecommended { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void CallerCanGetConsentlessPosition();
  }
}
