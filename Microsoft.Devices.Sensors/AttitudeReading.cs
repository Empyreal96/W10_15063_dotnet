// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.Sensors.AttitudeReading
// Assembly: Microsoft.Devices.Sensors, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 469A1B9D-3538-4EC4-AFBC-0CC2C106C824
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI782A~1.DLL

using Microsoft.Xna.Framework;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Devices.Sensors
{
  [SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes", Justification = "No need to do that")]
  public struct AttitudeReading : ISensorReading
  {
    public DateTimeOffset Timestamp { get; internal set; }

    public float Yaw { get; internal set; }

    public float Pitch { get; internal set; }

    public float Roll { get; internal set; }

    public Quaternion Quaternion { get; internal set; }

    public Matrix RotationMatrix { get; internal set; }

    internal AttitudeReading(DateTimeOffset timestamp, MotionNativeSample nativeSample)
      : this()
    {
      this.Timestamp = timestamp;
      this.Pitch = MathHelper.ToRadians(nativeSample.vecAttitudeEulerAngle.X);
      this.Roll = MathHelper.ToRadians(nativeSample.vecAttitudeEulerAngle.Y);
      this.Yaw = MathHelper.ToRadians(nativeSample.vecAttitudeEulerAngle.Z);
      this.Quaternion = new Quaternion()
      {
        W = nativeSample.qtnAttitude.W,
        X = nativeSample.qtnAttitude.X,
        Y = nativeSample.qtnAttitude.Y,
        Z = nativeSample.qtnAttitude.Z
      };
      this.RotationMatrix = new Matrix(nativeSample.m33Rotation.M11, nativeSample.m33Rotation.M12, nativeSample.m33Rotation.M13, 0.0f, nativeSample.m33Rotation.M21, nativeSample.m33Rotation.M22, nativeSample.m33Rotation.M23, 0.0f, nativeSample.m33Rotation.M31, nativeSample.m33Rotation.M32, nativeSample.m33Rotation.M33, 0.0f, 0.0f, 0.0f, 0.0f, 1f);
    }
  }
}
