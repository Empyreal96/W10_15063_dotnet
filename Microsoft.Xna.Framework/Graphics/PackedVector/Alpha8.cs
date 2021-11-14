// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.PackedVector.Alpha8
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
  public struct Alpha8 : IPackedVector<byte>, IPackedVector, IEquatable<Alpha8>
  {
    private byte packedValue;

    public Alpha8(float alpha) => this.packedValue = Alpha8.PackHelper(alpha);

    void IPackedVector.PackFromVector4(Vector4 vector) => this.packedValue = Alpha8.PackHelper(vector.W);

    private static byte PackHelper(float alpha) => (byte) PackUtils.PackUNorm((float) byte.MaxValue, alpha);

    public float ToAlpha() => PackUtils.UnpackUNorm((uint) byte.MaxValue, (uint) this.packedValue);

    Vector4 IPackedVector.ToVector4() => new Vector4(0.0f, 0.0f, 0.0f, this.ToAlpha());

    public byte PackedValue
    {
      get => this.packedValue;
      set => this.packedValue = value;
    }

    public override string ToString() => this.packedValue.ToString("X2", (IFormatProvider) CultureInfo.InvariantCulture);

    public override int GetHashCode() => this.packedValue.GetHashCode();

    public override bool Equals(object obj) => obj is Alpha8 other && this.Equals(other);

    public bool Equals(Alpha8 other) => this.packedValue.Equals(other.packedValue);

    public static bool operator ==(Alpha8 a, Alpha8 b) => a.Equals(b);

    public static bool operator !=(Alpha8 a, Alpha8 b) => !a.Equals(b);
  }
}
