// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedByte2
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
  public struct NormalizedByte2 : IPackedVector<ushort>, IPackedVector, IEquatable<NormalizedByte2>
  {
    private ushort packedValue;

    public NormalizedByte2(float x, float y) => this.packedValue = NormalizedByte2.PackHelper(x, y);

    public NormalizedByte2(Vector2 vector) => this.packedValue = NormalizedByte2.PackHelper(vector.X, vector.Y);

    void IPackedVector.PackFromVector4(Vector4 vector) => this.packedValue = NormalizedByte2.PackHelper(vector.X, vector.Y);

    private static ushort PackHelper(float vectorX, float vectorY) => (ushort) (PackUtils.PackSNorm((uint) byte.MaxValue, vectorX) | PackUtils.PackSNorm((uint) byte.MaxValue, vectorY) << 8);

    public Vector2 ToVector2()
    {
      Vector2 vector2;
      vector2.X = PackUtils.UnpackSNorm((uint) byte.MaxValue, (uint) this.packedValue);
      vector2.Y = PackUtils.UnpackSNorm((uint) byte.MaxValue, (uint) this.packedValue >> 8);
      return vector2;
    }

    Vector4 IPackedVector.ToVector4()
    {
      Vector2 vector2 = this.ToVector2();
      return new Vector4(vector2.X, vector2.Y, 0.0f, 1f);
    }

    [CLSCompliant(false)]
    public ushort PackedValue
    {
      get => this.packedValue;
      set => this.packedValue = value;
    }

    public override string ToString() => this.packedValue.ToString("X4", (IFormatProvider) CultureInfo.InvariantCulture);

    public override int GetHashCode() => this.packedValue.GetHashCode();

    public override bool Equals(object obj) => obj is NormalizedByte2 other && this.Equals(other);

    public bool Equals(NormalizedByte2 other) => this.packedValue.Equals(other.packedValue);

    public static bool operator ==(NormalizedByte2 a, NormalizedByte2 b) => a.Equals(b);

    public static bool operator !=(NormalizedByte2 a, NormalizedByte2 b) => !a.Equals(b);
  }
}
