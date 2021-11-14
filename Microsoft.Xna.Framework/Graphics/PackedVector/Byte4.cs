// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.PackedVector.Byte4
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
  public struct Byte4 : IPackedVector<uint>, IPackedVector, IEquatable<Byte4>
  {
    private uint packedValue;

    public Byte4(float x, float y, float z, float w) => this.packedValue = Byte4.PackHelper(x, y, z, w);

    public Byte4(Vector4 vector) => this.packedValue = Byte4.PackHelper(vector.X, vector.Y, vector.Z, vector.W);

    void IPackedVector.PackFromVector4(Vector4 vector) => this.packedValue = Byte4.PackHelper(vector.X, vector.Y, vector.Z, vector.W);

    private static uint PackHelper(float vectorX, float vectorY, float vectorZ, float vectorW)
    {
      int num1 = (int) PackUtils.PackUnsigned((float) byte.MaxValue, vectorX);
      uint num2 = PackUtils.PackUnsigned((float) byte.MaxValue, vectorY) << 8;
      uint num3 = PackUtils.PackUnsigned((float) byte.MaxValue, vectorZ) << 16;
      uint num4 = PackUtils.PackUnsigned((float) byte.MaxValue, vectorW) << 24;
      int num5 = (int) num2;
      return (uint) (num1 | num5) | num3 | num4;
    }

    public Vector4 ToVector4()
    {
      Vector4 vector4;
      vector4.X = (float) (this.packedValue & (uint) byte.MaxValue);
      vector4.Y = (float) (this.packedValue >> 8 & (uint) byte.MaxValue);
      vector4.Z = (float) (this.packedValue >> 16 & (uint) byte.MaxValue);
      vector4.W = (float) (this.packedValue >> 24 & (uint) byte.MaxValue);
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

    public override bool Equals(object obj) => obj is Byte4 other && this.Equals(other);

    public bool Equals(Byte4 other) => this.packedValue.Equals(other.packedValue);

    public static bool operator ==(Byte4 a, Byte4 b) => a.Equals(b);

    public static bool operator !=(Byte4 a, Byte4 b) => !a.Equals(b);
  }
}
