﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.CompassReading
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class CompassReading : ICompassReading, ICompassReadingHeadingAccuracy
  {
    public extern DateTime Timestamp { [MethodImpl] get; }

    public extern double HeadingMagneticNorth { [MethodImpl] get; }

    public extern IReference<double> HeadingTrueNorth { [MethodImpl] get; }

    public extern MagnetometerAccuracy HeadingAccuracy { [MethodImpl] get; }
  }
}
