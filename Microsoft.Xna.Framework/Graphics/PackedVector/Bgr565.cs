// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.PackedVector.Bgr565
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
  public struct Bgr565 : IPackedVector<ushort>, IPackedVector, IEquatable<Bgr565>
  {
    private ushort packedValue;

    public Bgr565(float x, float y, float z) => this.packedValue = Bgr565.PackHelper(x, y, z);

    public Bgr565(Vector3 vector) => this.packedValue = Bgr565.PackHelper(vector.X, vector.Y, vector.Z);

    void IPackedVector.PackFromVector4(Vector4 vector) => this.packedValue = Bgr565.PackHelper(vector.X, vector.Y, vector.Z);

    private static ushort PackHelper(float vectorX, float vectorY, float vectorZ)
    {
      int num1 = (int) PackUtils.PackUNorm(31f, vectorX) << 11;
      uint num2 = PackUtils.PackUNorm(63f, vectorY) << 5;
      uint num3 = PackUtils.PackUNorm(31f, vectorZ);
      int num4 = (int) num2;
      return (ushort) ((uint) (num1 | num4) | num3);
    }

    public Vector3 ToVector3()
    {
      Vector3 vector3;
      vector3.X = PackUtils.UnpackUNorm(31U, (uint) this.packedValue >> 11);
      vector3.Y = PackUtils.UnpackUNorm(63U, (uint) this.packedValue >> 5);
      vector3.Z = PackUtils.UnpackUNorm(31U, (uint) this.packedValue);
      return vector3;
    }

    Vector4 IPackedVector.ToVector4()
    {
      Vector3 vector3 = this.ToVector3();
      return new Vector4(vector3.X, vector3.Y, vector3.Z, 1f);
    }

    [CLSCompliant(false)]
    public ushort PackedValue
    {
      get => this.packedValue;
      set => this.packedValue = value;
    }

    public override string ToString() => this.packedValue.ToString("X4", (IFormatProvider) CultureInfo.InvariantCulture);

    public override int GetHashCode() => this.packedValue.GetHashCode();

    public override bool Equals(object obj) => obj is Bgr565 other && this.Equals(other);

    public bool Equals(Bgr565 other) => this.packedValue.Equals(other.packedValue);

    public static bool operator ==(Bgr565 a, Bgr565 b) => a.Equals(b);

    public static bool operator !=(Bgr565 a, Bgr565 b) => !a.Equals(b);
  }
}
