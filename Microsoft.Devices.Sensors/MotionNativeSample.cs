// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.Sensors.MotionNativeSample
// Assembly: Microsoft.Devices.Sensors, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 469A1B9D-3538-4EC4-AFBC-0CC2C106C824
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI782A~1.DLL

namespace Microsoft.Devices.Sensors
{
  internal struct MotionNativeSample
  {
    public SensorNativeSampleHeader header;
    public VEC3D vecGravity;
    public VEC3D vecTrueNorth;
    public VEC3D vecRotationRate;
    public VEC3D vecAttitudeEulerAngle;
    public QUATERNION qtnAttitude;
    public MATRIX3X3 m33Rotation;
    public VEC3D vecLinearAcceleration;
  }
}
