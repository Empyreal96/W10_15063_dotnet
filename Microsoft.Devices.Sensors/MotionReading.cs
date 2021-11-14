// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.Sensors.MotionReading
// Assembly: Microsoft.Devices.Sensors, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 469A1B9D-3538-4EC4-AFBC-0CC2C106C824
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI782A~1.DLL

using Microsoft.Xna.Framework;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Devices.Sensors
{
  [SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes", Justification = "No need to do that")]
  public struct MotionReading : ISensorReading
  {
    public DateTimeOffset Timestamp { get; internal set; }

    public AttitudeReading Attitude { get; internal set; }

    public Vector3 DeviceAcceleration { get; internal set; }

    public Vector3 Gravity { get; internal set; }

    public Vector3 DeviceRotationRate { get; internal set; }

    internal MotionReading(MotionNativeSample nativeSample)
      : this()
    {
      this.Timestamp = nativeSample.header.TimeStamp;
      this.DeviceAcceleration = new Vector3(nativeSample.vecLinearAcceleration.X, nativeSample.vecLinearAcceleration.Y, nativeSample.vecLinearAcceleration.Z);
      this.Gravity = new Vector3(nativeSample.vecGravity.X, nativeSample.vecGravity.Y, nativeSample.vecGravity.Z);
      this.DeviceRotationRate = new Vector3(MathHelper.ToRadians(nativeSample.vecRotationRate.X), MathHelper.ToRadians(nativeSample.vecRotationRate.Y), MathHelper.ToRadians(nativeSample.vecRotationRate.Z));
      this.Attitude = new AttitudeReading(this.Timestamp, nativeSample);
    }
  }
}
