﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.AccelerometerReading
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AccelerometerReading : IAccelerometerReading
  {
    public extern DateTime Timestamp { [MethodImpl] get; }

    public extern double AccelerationX { [MethodImpl] get; }

    public extern double AccelerationY { [MethodImpl] get; }

    public extern double AccelerationZ { [MethodImpl] get; }
  }
}
