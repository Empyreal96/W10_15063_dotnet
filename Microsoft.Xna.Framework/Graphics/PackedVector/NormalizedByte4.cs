// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedByte4
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
  public struct NormalizedByte4 : IPackedVector<uint>, IPackedVector, IEquatable<NormalizedByte4>
  {
    private uint packedValue;

    public NormalizedByte4(float x, float y, float z, float w) => this.packedValue = NormalizedByte4.PackHelper(x, y, z, w);

    public NormalizedByte4(Vector4 vector) => this.packedValue = NormalizedByte4.PackHelper(vector.X, vector.Y, vector.Z, vector.W);

    void IPackedVector.PackFromVector4(Vector4 vector) => this.packedValue = NormalizedByte4.PackHelper(vector.X, vector.Y, vector.Z, vector.W);

    private static uint PackHelper(float vectorX, float vectorY, float vectorZ, float vectorW)
    {
      int num1 = (int) PackUtils.PackSNorm((uint) byte.MaxValue, vectorX);
      uint num2 = PackUtils.PackSNorm((uint) byte.MaxValue, vectorY) << 8;
      uint num3 = PackUtils.PackSNorm((uint) byte.MaxValue, vectorZ) << 16;
      uint num4 = PackUtils.PackSNorm((uint) byte.MaxValue, vectorW) << 24;
      int num5 = (int) num2;
      return (uint) (num1 | num5) | num3 | num4;
    }

    public Vector4 ToVector4()
    {
      Vector4 vector4;
      vector4.X = PackUtils.UnpackSNorm((uint) byte.MaxValue, this.packedValue);
      vector4.Y = PackUtils.UnpackSNorm((uint) byte.MaxValue, this.packedValue >> 8);
      vector4.Z = PackUtils.UnpackSNorm((uint) byte.MaxValue, this.packedValue >> 16);
      vector4.W = PackUtils.UnpackSNorm((uint) byte.MaxValue, this.packedValue >> 24);
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

    public override bool Equals(object obj) => obj is NormalizedByte4 other && this.Equals(other);

    public bool Equals(NormalizedByte4 other) => this.packedValue.Equals(other.packedValue);

    public static bool operator ==(NormalizedByte4 a, NormalizedByte4 b) => a.Equals(b);

    public static bool operator !=(NormalizedByte4 a, NormalizedByte4 b) => !a.Equals(b);
  }
}
