// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.PackedVector.Rgba64
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
  public struct Rgba64 : IPackedVector<ulong>, IPackedVector, IEquatable<Rgba64>
  {
    private ulong packedValue;

    public Rgba64(float x, float y, float z, float w) => this.packedValue = Rgba64.PackHelper(x, y, z, w);

    public Rgba64(Vector4 vector) => this.packedValue = Rgba64.PackHelper(vector.X, vector.Y, vector.Z, vector.W);

    void IPackedVector.PackFromVector4(Vector4 vector) => this.packedValue = Rgba64.PackHelper(vector.X, vector.Y, vector.Z, vector.W);

    private static ulong PackHelper(float vectorX, float vectorY, float vectorZ, float vectorW)
    {
      long num1 = (long) PackUtils.PackUNorm((float) ushort.MaxValue, vectorX);
      ulong num2 = (ulong) PackUtils.PackUNorm((float) ushort.MaxValue, vectorY) << 16;
      ulong num3 = (ulong) PackUtils.PackUNorm((float) ushort.MaxValue, vectorZ) << 32;
      ulong num4 = (ulong) PackUtils.PackUNorm((float) ushort.MaxValue, vectorW) << 48;
      long num5 = (long) num2;
      return (ulong) (num1 | num5) | num3 | num4;
    }

    public Vector4 ToVector4()
    {
      Vector4 vector4;
      vector4.X = PackUtils.UnpackUNorm((uint) ushort.MaxValue, (uint) this.packedValue);
      vector4.Y = PackUtils.UnpackUNorm((uint) ushort.MaxValue, (uint) (this.packedValue >> 16));
      vector4.Z = PackUtils.UnpackUNorm((uint) ushort.MaxValue, (uint) (this.packedValue >> 32));
      vector4.W = PackUtils.UnpackUNorm((uint) ushort.MaxValue, (uint) (this.packedValue >> 48));
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

    public override bool Equals(object obj) => obj is Rgba64 other && this.Equals(other);

    public bool Equals(Rgba64 other) => this.packedValue.Equals(other.packedValue);

    public static bool operator ==(Rgba64 a, Rgba64 b) => a.Equals(b);

    public static bool operator !=(Rgba64 a, Rgba64 b) => !a.Equals(b);
  }
}
