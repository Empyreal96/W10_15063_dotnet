// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.Sensors.GyroscopeReading
// Assembly: Microsoft.Devices.Sensors, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 469A1B9D-3538-4EC4-AFBC-0CC2C106C824
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI782A~1.DLL

using Microsoft.Xna.Framework;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Devices.Sensors
{
  [SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes", Justification = "No need to do that")]
  public struct GyroscopeReading : ISensorReading
  {
    public DateTimeOffset Timestamp { get; internal set; }

    public Vector3 RotationRate { get; internal set; }

    internal GyroscopeReading(GyroscopeNativeSample nativeSample)
      : this()
    {
      this.RotationRate = new Vector3(MathHelper.ToRadians(nativeSample.x), MathHelper.ToRadians(nativeSample.y), MathHelper.ToRadians(nativeSample.z));
      this.Timestamp = nativeSample.header.TimeStamp;
    }
  }
}
