// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.CurveKey
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Xna.Framework
{
  public class CurveKey : IEquatable<CurveKey>, IComparable<CurveKey>
  {
    internal float position;
    internal float internalValue;
    internal float tangentOut;
    internal float tangentIn;
    internal CurveContinuity continuity;

    public float Position => this.position;

    public float Value
    {
      get => this.internalValue;
      set => this.internalValue = value;
    }

    public float TangentIn
    {
      get => this.tangentIn;
      set => this.tangentIn = value;
    }

    public float TangentOut
    {
      get => this.tangentOut;
      set => this.tangentOut = value;
    }

    public CurveContinuity Continuity
    {
      get => this.continuity;
      set => this.continuity = value;
    }

    public CurveKey(float position, float value)
    {
      this.position = position;
      this.internalValue = value;
    }

    public CurveKey(float position, float value, float tangentIn, float tangentOut)
    {
      this.position = position;
      this.internalValue = value;
      this.tangentIn = tangentIn;
      this.tangentOut = tangentOut;
    }

    public CurveKey(
      float position,
      float value,
      float tangentIn,
      float tangentOut,
      CurveContinuity continuity)
    {
      this.position = position;
      this.internalValue = value;
      this.tangentIn = tangentIn;
      this.tangentOut = tangentOut;
      this.continuity = continuity;
    }

    public CurveKey Clone() => new CurveKey(this.position, this.internalValue, this.tangentIn, this.tangentOut, this.continuity);

    public bool Equals(CurveKey other) => other != (CurveKey) null && (double) other.position == (double) this.position && ((double) other.internalValue == (double) this.internalValue && (double) other.tangentIn == (double) this.tangentIn) && (double) other.tangentOut == (double) this.tangentOut && other.continuity == this.continuity;

    public override bool Equals(object obj) => this.Equals(obj as CurveKey);

    public override int GetHashCode() => this.position.GetHashCode() + this.internalValue.GetHashCode() + this.tangentIn.GetHashCode() + this.tangentOut.GetHashCode() + this.continuity.GetHashCode();

    [SuppressMessage("Microsoft.Design", "CA1062")]
    public static bool operator ==(CurveKey a, CurveKey b)
    {
      bool flag1 = (object) a == null;
      bool flag2 = (object) b == null;
      return !(flag1 | flag2) ? a.Equals(b) : flag1 == flag2;
    }

    public static bool operator !=(CurveKey a, CurveKey b)
    {
      bool flag1 = a == (CurveKey) null;
      bool flag2 = b == (CurveKey) null;
      return !(flag1 | flag2) ? (double) a.position != (double) b.position || (double) a.internalValue != (double) b.internalValue || ((double) a.tangentIn != (double) b.tangentIn || (double) a.tangentOut != (double) b.tangentOut) || a.continuity != b.continuity : flag1 != flag2;
    }

    public int CompareTo(CurveKey other)
    {
      if ((double) this.position == (double) other.position)
        return 0;
      return (double) this.position >= (double) other.position ? 1 : -1;
    }
  }
}
