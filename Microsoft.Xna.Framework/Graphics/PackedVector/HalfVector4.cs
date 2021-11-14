// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.PackedVector.HalfVector4
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
  public struct HalfVector4 : IPackedVector<ulong>, IPackedVector, IEquatable<HalfVector4>
  {
    private ulong packedValue;

    public HalfVector4(float x, float y, float z, float w) => this.packedValue = HalfVector4.PackHelper(x, y, z, w);

    public HalfVector4(Vector4 vector) => this.packedValue = HalfVector4.PackHelper(vector.X, vector.Y, vector.Z, vector.W);

    void IPackedVector.PackFromVector4(Vector4 vector) => this.packedValue = HalfVector4.PackHelper(vector.X, vector.Y, vector.Z, vector.W);

    private static ulong PackHelper(float vectorX, float vectorY, float vectorZ, float vectorW)
    {
      long num1 = (long) HalfUtils.Pack(vectorX);
      ulong num2 = (ulong) HalfUtils.Pack(vectorY) << 16;
      ulong num3 = (ulong) HalfUtils.Pack(vectorZ) << 32;
      ulong num4 = (ulong) HalfUtils.Pack(vectorW) << 48;
      long num5 = (long) num2;
      return (ulong) (num1 | num5) | num3 | num4;
    }

    public Vector4 ToVector4()
    {
      Vector4 vector4;
      vector4.X = HalfUtils.Unpack((ushort) this.packedValue);
      vector4.Y = HalfUtils.Unpack((ushort) (this.packedValue >> 16));
      vector4.Z = HalfUtils.Unpack((ushort) (this.packedValue >> 32));
      vector4.W = HalfUtils.Unpack((ushort) (this.packedValue >> 48));
      return vector4;
    }

    [CLSCompliant(false)]
    public ulong PackedValue
    {
      get => this.packedValue;
      set => this.packedValue = value;
    }

    public override string ToString() => this.ToVector4().ToString();

    public override int GetHashCode() => this.packedValue.GetHashCode();

    public override bool Equals(object obj) => obj is HalfVector4 other && this.Equals(other);

    public bool Equals(HalfVector4 other) => this.packedValue.Equals(other.packedValue);

    public static bool operator ==(HalfVector4 a, HalfVector4 b) => a.Equals(b);

    public static bool operator !=(HalfVector4 a, HalfVector4 b) => !a.Equals(b);
  }
}
