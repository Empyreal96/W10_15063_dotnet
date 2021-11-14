// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort4
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
  public struct NormalizedShort4 : IPackedVector<ulong>, IPackedVector, IEquatable<NormalizedShort4>
  {
    private ulong packedValue;

    public NormalizedShort4(float x, float y, float z, float w) => this.packedValue = NormalizedShort4.PackHelper(x, y, z, w);

    public NormalizedShort4(Vector4 vector) => this.packedValue = NormalizedShort4.PackHelper(vector.X, vector.Y, vector.Z, vector.W);

    void IPackedVector.PackFromVector4(Vector4 vector) => this.packedValue = NormalizedShort4.PackHelper(vector.X, vector.Y, vector.Z, vector.W);

    private static ulong PackHelper(float vectorX, float vectorY, float vectorZ, float vectorW)
    {
      long num1 = (long) PackUtils.PackSNorm((uint) ushort.MaxValue, vectorX);
      ulong num2 = (ulong) PackUtils.PackSNorm((uint) ushort.MaxValue, vectorY) << 16;
      ulong num3 = (ulong) PackUtils.PackSNorm((uint) ushort.MaxValue, vectorZ) << 32;
      ulong num4 = (ulong) PackUtils.PackSNorm((uint) ushort.MaxValue, vectorW) << 48;
      long num5 = (long) num2;
      return (ulong) (num1 | num5) | num3 | num4;
    }

    public Vector4 ToVector4()
    {
      Vector4 vector4;
      vector4.X = PackUtils.UnpackSNorm((uint) ushort.MaxValue, (uint) this.packedValue);
      vector4.Y = PackUtils.UnpackSNorm((uint) ushort.MaxValue, (uint) (this.packedValue >> 16));
      vector4.Z = PackUtils.UnpackSNorm((uint) ushort.MaxValue, (uint) (this.packedValue >> 32));
      vector4.W = PackUtils.UnpackSNorm((uint) ushort.MaxValue, (uint) (this.packedValue >> 48));
      return vector4;
    }

    [CLSCompliant(false)]
    public ulong PackedValue
    {
      get => this.packedValue;
      set => this.packedValue = value;
    }

    public override string ToString() => this.packedValue.ToString("X16", (IFormatProvider) CultureInfo.InvariantCulture);

    public override int GetHashCode() => this.packedValue.GetHashCode();

    public override bool Equals(object obj) => obj is NormalizedShort4 other && this.Equals(other);

    public bool Equals(NormalizedShort4 other) => this.packedValue.Equals(other.packedValue);

    public static bool operator ==(NormalizedShort4 a, NormalizedShort4 b) => a.Equals(b);

    public static bool operator !=(NormalizedShort4 a, NormalizedShort4 b) => !a.Equals(b);
  }
}
