// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.PackedVector.HalfSingle
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
  public struct HalfSingle : IPackedVector<ushort>, IPackedVector, IEquatable<HalfSingle>
  {
    private ushort packedValue;

    public HalfSingle(float value) => this.packedValue = HalfUtils.Pack(value);

    void IPackedVector.PackFromVector4(Vector4 vector) => this.packedValue = HalfUtils.Pack(vector.X);

    public float ToSingle() => HalfUtils.Unpack(this.packedValue);

    Vector4 IPackedVector.ToVector4() => new Vector4(this.ToSingle(), 0.0f, 0.0f, 1f);

    [CLSCompliant(false)]
    public ushort PackedValue
    {
      get => this.packedValue;
      set => this.packedValue = value;
    }

    public override string ToString() => this.ToSingle().ToString((IFormatProvider) CultureInfo.InvariantCulture);

    public override int GetHashCode() => this.packedValue.GetHashCode();

    public override bool Equals(object obj) => obj is HalfSingle other && this.Equals(other);

    public bool Equals(HalfSingle other) => this.packedValue.Equals(other.packedValue);

    public static bool operator ==(HalfSingle a, HalfSingle b) => a.Equals(b);

    public static bool operator !=(HalfSingle a, HalfSingle b) => !a.Equals(b);
  }
}
