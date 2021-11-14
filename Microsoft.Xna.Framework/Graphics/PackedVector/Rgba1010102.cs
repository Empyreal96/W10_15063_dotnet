// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.PackedVector.Rgba1010102
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
  public struct Rgba1010102 : IPackedVector<uint>, IPackedVector, IEquatable<Rgba1010102>
  {
    private uint packedValue;

    public Rgba1010102(float x, float y, float z, float w) => this.packedValue = Rgba1010102.PackHelper(x, y, z, w);

    public Rgba1010102(Vector4 vector) => this.packedValue = Rgba1010102.PackHelper(vector.X, vector.Y, vector.Z, vector.W);

    void IPackedVector.PackFromVector4(Vector4 vector) => this.packedValue = Rgba1010102.PackHelper(vector.X, vector.Y, vector.Z, vector.W);

    private static uint PackHelper(float vectorX, float vectorY, float vectorZ, float vectorW)
    {
      int num1 = (int) PackUtils.PackUNorm(1023f, vectorX);
      uint num2 = PackUtils.PackUNorm(1023f, vectorY) << 10;
      uint num3 = PackUtils.PackUNorm(1023f, vectorZ) << 20;
      uint num4 = PackUtils.PackUNorm(3f, vectorW) << 30;
      int num5 = (int) num2;
      return (uint) (num1 | num5) | num3 | num4;
    }

    public Vector4 ToVector4()
    {
      Vector4 vector4;
      vector4.X = PackUtils.UnpackUNorm(1023U, this.packedValue);
      vector4.Y = PackUtils.UnpackUNorm(1023U, this.packedValue >> 10);
      vector4.Z = PackUtils.UnpackUNorm(1023U, this.packedValue >> 20);
      vector4.W = PackUtils.UnpackUNorm(3U, this.packedValue >> 30);
      return vector4;
    }

    [CLSCompliant(false)]
    public uint PackedValue
    {
      get => this.packedValue;
      set => this.packedValue = value;
    }

    public override string ToString() => this.packedValue.ToString("X8", (IFormatProvider) CultureInfo.InvariantCulture);

    public override int GetHashCode() => this.packedValue.GetHashCode();

    public override bool Equals(object obj) => obj is Rgba1010102 other && this.Equals(other);

    public bool Equals(Rgba1010102 other) => this.packedValue.Equals(other.packedValue);

    public static bool operator ==(Rgba1010102 a, Rgba1010102 b) => a.Equals(b);

    public static bool operator !=(Rgba1010102 a, Rgba1010102 b) => !a.Equals(b);
  }
}
