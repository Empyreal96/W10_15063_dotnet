// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.PackedVector.Bgra4444
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
  public struct Bgra4444 : IPackedVector<ushort>, IPackedVector, IEquatable<Bgra4444>
  {
    private ushort packedValue;

    public Bgra4444(float x, float y, float z, float w) => this.packedValue = Bgra4444.PackHelper(x, y, z, w);

    public Bgra4444(Vector4 vector) => this.packedValue = Bgra4444.PackHelper(vector.X, vector.Y, vector.Z, vector.W);

    void IPackedVector.PackFromVector4(Vector4 vector) => this.packedValue = Bgra4444.PackHelper(vector.X, vector.Y, vector.Z, vector.W);

    private static ushort PackHelper(float vectorX, float vectorY, float vectorZ, float vectorW)
    {
      int num1 = (int) PackUtils.PackUNorm(15f, vectorX) << 8;
      uint num2 = PackUtils.PackUNorm(15f, vectorY) << 4;
      uint num3 = PackUtils.PackUNorm(15f, vectorZ);
      uint num4 = PackUtils.PackUNorm(15f, vectorW) << 12;
      int num5 = (int) num2;
      return (ushort) ((uint) (num1 | num5) | num3 | num4);
    }

    public Vector4 ToVector4()
    {
      Vector4 vector4;
      vector4.X = PackUtils.UnpackUNorm(15U, (uint) this.packedValue >> 8);
      vector4.Y = PackUtils.UnpackUNorm(15U, (uint) this.packedValue >> 4);
      vector4.Z = PackUtils.UnpackUNorm(15U, (uint) this.packedValue);
      vector4.W = PackUtils.UnpackUNorm(15U, (uint) this.packedValue >> 12);
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

    public override bool Equals(object obj) => obj is Bgra4444 other && this.Equals(other);

    public bool Equals(Bgra4444 other) => this.packedValue.Equals(other.packedValue);

    public static bool operator ==(Bgra4444 a, Bgra4444 b) => a.Equals(b);

    public static bool operator !=(Bgra4444 a, Bgra4444 b) => !a.Equals(b);
  }
}
