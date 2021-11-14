// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.PackedVector.Bgra5551
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
  public struct Bgra5551 : IPackedVector<ushort>, IPackedVector, IEquatable<Bgra5551>
  {
    private ushort packedValue;

    public Bgra5551(float x, float y, float z, float w) => this.packedValue = Bgra5551.PackHelper(x, y, z, w);

    public Bgra5551(Vector4 vector) => this.packedValue = Bgra5551.PackHelper(vector.X, vector.Y, vector.Z, vector.W);

    void IPackedVector.PackFromVector4(Vector4 vector) => this.packedValue = Bgra5551.PackHelper(vector.X, vector.Y, vector.Z, vector.W);

    private static ushort PackHelper(float vectorX, float vectorY, float vectorZ, float vectorW)
    {
      int num1 = (int) PackUtils.PackUNorm(31f, vectorX) << 10;
      uint num2 = PackUtils.PackUNorm(31f, vectorY) << 5;
      uint num3 = PackUtils.PackUNorm(31f, vectorZ);
      uint num4 = PackUtils.PackUNorm(1f, vectorW) << 15;
      int num5 = (int) num2;
      return (ushort) ((uint) (num1 | num5) | num3 | num4);
    }

    public Vector4 ToVector4()
    {
      Vector4 vector4;
      vector4.X = PackUtils.UnpackUNorm(31U, (uint) this.packedValue >> 10);
      vector4.Y = PackUtils.UnpackUNorm(31U, (uint) this.packedValue >> 5);
      vector4.Z = PackUtils.UnpackUNorm(31U, (uint) this.packedValue);
      vector4.W = PackUtils.UnpackUNorm(1U, (uint) this.packedValue >> 15);
      return vector4;
    }

    [CLSCompliant(false)]
    public ushort PackedValue
    {
      get => this.packedValue;
      set => this.packedValue = value;
    }

    public override string ToString() => this.packedValue.ToString("X4", (IFormatProvider) CultureInfo.InvariantCulture);

    public override int GetHashCode() => this.packedValue.GetHashCode();

    public override bool Equals(object obj) => obj is Bgra5551 other && this.Equals(other);

    public bool Equals(Bgra5551 other) => this.packedValue.Equals(other.packedValue);

    public static bool operator ==(Bgra5551 a, Bgra5551 b) => a.Equals(b);

    public static bool operator !=(Bgra5551 a, Bgra5551 b) => !a.Equals(b);
  }
}
