﻿// Decompiled with JetBrains decompiler
// Type: LocationServiceInterop.LOCATIONREQUEST
// Assembly: LocationService.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 0F7FF74F-5B20-469A-BF3F-5B3C20DFBAEC
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\LOCATI~3.DLL

using System.Runtime.InteropServices;

namespace LocationServiceInterop
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct LOCATIONREQUEST
  {
    public LOCATIONREQUEST_SESSIONTYPE SessionType;
    public __MIDL___MIDL_itf_locationframework_0000_0000_0002 __MIDL____MIDL_itf_locationframework_0000_00000000;
    public int VenueInformationMandatory;
    public __MIDL___MIDL_itf_locationframework_0000_0000_0001 PreferedAcquireType;
    public LOCATION_POSITIONINGENGINE RequestSourcePe;
    public uint SessionFlags;
  }
}