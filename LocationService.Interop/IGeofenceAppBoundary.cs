// Decompiled with JetBrains decompiler
// Type: LocationServiceInterop.IGeofenceAppBoundary
// Assembly: LocationService.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 0F7FF74F-5B20-469A-BF3F-5B3C20DFBAEC
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\LOCATI~3.DLL

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LocationServiceInterop
{
  [Guid("5FBE70F3-2F8D-46BC-BA97-28E3E9D51F9C")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComConversionLoss]
  [ComImport]
  public interface IGeofenceAppBoundary
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Add([In, Out] ref GEOFENCE pGeofence);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Remove([In] GEOFENCE_ID GeofenceId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RemoveAllGeofences();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void List(out uint pGeofencesCount, [Out] IntPtr ppGeofences);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs((UnmanagedType) 19)]
    string get_ForegroundEventName([In] LOCATION_TRIGGER_TYPE TriggerType);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RegisterForChanges([In] LOCATION_TRIGGER_TYPE TriggerType);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void UnregisterForChanges([In] LOCATION_TRIGGER_TYPE TriggerType);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetGeofenceStateChangedReports(out uint pReportsCount, [Out] IntPtr ppReport);

    [DispId(1610678280)]
    GEOFENCE_MONITORING_STATUS MonitoringStatus { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void UninstallApp();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetInternalId(out uint pId);
  }
}
