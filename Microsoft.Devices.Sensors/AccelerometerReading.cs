// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.Sensors.AccelerometerReading
// Assembly: Microsoft.Devices.Sensors, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 469A1B9D-3538-4EC4-AFBC-0CC2C106C824
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI782A~1.DLL

using Microsoft.Xna.Framework;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Devices.Sensors
{
  [SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes", Justification = "No need to do that")]
  public struct AccelerometerReading : ISensorReading
  {
    public DateTimeOffset Timestamp { get; internal set; }

    public Vector3 Acceleration { get; internal set; }

    internal AccelerometerReading(AccelerometerNativeSample nativeSample)
      : this()
    {
      this.Acceleration = new Vector3(nativeSample.x, nativeSample.y, nativeSample.z);
      this.Timestamp = nativeSample.header.TimeStamp;
    }
  }
}
