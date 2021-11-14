// Decompiled with JetBrains decompiler
// Type: LocationServiceInterop.__MIDL___MIDL_itf_locationframework_0000_0000_0002
// Assembly: LocationService.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 0F7FF74F-5B20-469A-BF3F-5B3C20DFBAEC
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\LOCATI~3.DLL

using System.Runtime.InteropServices;

namespace LocationServiceInterop
{
  [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 4)]
  public struct __MIDL___MIDL_itf_locationframework_0000_0000_0002
  {
    [FieldOffset(0)]
    public LOCATIONREQUEST_SINGLESHOT SingleShot;
    [FieldOffset(0)]
    public LOCATIONREQUEST_DISTANCETRACKING DistanceTracking;
    [FieldOffset(0)]
    public LOCATIONREQUEST_PERIODICTRACKING PeriodicTracking;
  }
}
