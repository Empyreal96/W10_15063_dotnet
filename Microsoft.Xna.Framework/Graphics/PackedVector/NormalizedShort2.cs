// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort2
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
  public struct NormalizedShort2 : IPackedVector<uint>, IPackedVector, IEquatable<NormalizedShort2>
  {
    private uint packedValue;

    public NormalizedShort2(float x, float y) => this.packedValue = NormalizedShort2.PackHelper(x, y);

    public NormalizedShort2(Vector2 vector) => this.packedValue = NormalizedShort2.PackHelper(vector.X, vector.Y);

    void IPackedVector.PackFromVector4(Vector4 vector) => this.packedValue = NormalizedShort2.PackHelper(vector.X, vector.Y);

    private static uint PackHelper(float vectorX, float vectorY) => PackUtils.PackSNorm((uint) ushort.MaxValue, vectorX) | PackUtils.PackSNorm((uint) ushort.MaxValue, vectorY) << 16;

    public Vector2 ToVector2()
    {
      Vector2 vector2;
      vector2.X = PackUtils.UnpackSNorm((uint) ushort.MaxValue, this.packedValue);
      vector2.Y = PackUtils.UnpackSNorm((uint) ushort.MaxValue, this.packedValue >> 16);
      return vector2;
    }

    Vector4 IPackedVector.ToVector4()
    {
      Vector2 vector2 = this.ToVector2();
      return new Vector4(vector2.X, vector2.Y, 0.0f, 1f);
    }

    [CLSCompliant(false)]
    public uint PackedValue
    {
      get => this.packedValue;
      set => this.packedValue = value;
    }

    public override string ToString() => this.packedValue.ToString("X8", (IFormatProvider) CultureInfo.InvariantCulture);

    public override int GetHashCode() => this.packedValue.GetHashCode();

    public override bool Equals(object obj) => obj is NormalizedShort2 other && this.Equals(other);

    public bool Equals(NormalizedShort2 other) => this.packedValue.Equals(other.packedValue);

    public static bool operator ==(NormalizedShort2 a, NormalizedShort2 b) => a.Equals(b);

    public static bool operator !=(NormalizedShort2 a, NormalizedShort2 b) => !a.Equals(b);
  }
}
