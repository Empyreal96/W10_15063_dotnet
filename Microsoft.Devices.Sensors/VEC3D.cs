// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.Sensors.VEC3D
// Assembly: Microsoft.Devices.Sensors, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 469A1B9D-3538-4EC4-AFBC-0CC2C106C824
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI782A~1.DLL

namespace Microsoft.Devices.Sensors
{
  internal struct VEC3D
  {
    internal float X;
    internal float Y;
    internal float Z;

    internal VEC3D(int x, int y, int z)
    {
      this.X = (float) x;
      this.Y = (float) y;
      this.Z = (float) z;
    }

    public override string ToString() => "X " + (object) this.X + " Y " + (object) this.Y + " Z " + (object) this.Z;
  }
}
