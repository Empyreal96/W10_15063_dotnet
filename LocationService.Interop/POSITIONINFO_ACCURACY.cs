﻿// Decompiled with JetBrains decompiler
// Type: LocationServiceInterop.POSITIONINFO_ACCURACY
// Assembly: LocationService.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 0F7FF74F-5B20-469A-BF3F-5B3C20DFBAEC
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\LOCATI~3.DLL

using System.Runtime.InteropServices;

namespace LocationServiceInterop
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct POSITIONINFO_ACCURACY
  {
    public uint HorizontalErrorMajorAxis;
    public uint HorizontalErrorMinorAxis;
    public uint HeadingAccuracy;
    public uint AltitudeAccuracy;
    public uint SpeedAccuracy;
    public uint HorizontalConfidence;
    public uint HeadingConfidence;
    public uint AltitudeConfidence;
    public uint SpeedConfidence;
    public float PositionDilutionOfPrecision;
    public float HorizontalDilutionOfPrecision;
    public float VerticalDilutionOfPrecision;
    public uint Flags;
  }
}