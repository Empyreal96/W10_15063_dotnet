// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Curve
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;

namespace Microsoft.Xna.Framework
{
  public class Curve
  {
    private CurveLoopType preLoop;
    private CurveLoopType postLoop;
    private CurveKeyCollection keys = new CurveKeyCollection();

    public CurveLoopType PreLoop
    {
      get => this.preLoop;
      set => this.preLoop = value;
    }

    public CurveLoopType PostLoop
    {
      get => this.postLoop;
      set => this.postLoop = value;
    }

    public CurveKeyCollection Keys => this.keys;

    public bool IsConstant => this.keys.Count <= 1;

    public Curve Clone() => new Curve()
    {
      preLoop = this.preLoop,
      postLoop = this.postLoop,
      keys = this.keys.Clone()
    };

    public void ComputeTangent(int keyIndex, CurveTangent tangentType)
    {
      int keyIndex1 = keyIndex;
      int num = (int) tangentType;
      this.ComputeTangent(keyIndex1, (CurveTangent) num, (CurveTangent) num);
    }

    public void ComputeTangent(
      int keyIndex,
      CurveTangent tangentInType,
      CurveTangent tangentOutType)
    {
      if (this.keys.Count <= keyIndex || keyIndex < 0)
        throw new ArgumentOutOfRangeException(nameof (keyIndex));
      CurveKey key = this.Keys[keyIndex];
      double position;
      float num1 = (float) (position = (double) key.Position);
      float num2 = (float) position;
      float num3 = (float) position;
      double num4;
      float num5 = (float) (num4 = (double) key.Value);
      float num6 = (float) num4;
      float num7 = (float) num4;
      if (keyIndex > 0)
      {
        num3 = this.Keys[keyIndex - 1].Position;
        num7 = this.Keys[keyIndex - 1].Value;
      }
      if (keyIndex + 1 < this.keys.Count)
      {
        num1 = this.Keys[keyIndex + 1].Position;
        num5 = this.Keys[keyIndex + 1].Value;
      }
      switch (tangentInType)
      {
        case CurveTangent.Linear:
          key.TangentIn = num6 - num7;
          break;
        case CurveTangent.Smooth:
          float num8 = num1 - num3;
          float num9 = num5 - num7;
          key.TangentIn = (double) Math.Abs(num9) >= 1.19209289550781E-07 ? num9 * Math.Abs(num3 - num2) / num8 : 0.0f;
          break;
        default:
          key.TangentIn = 0.0f;
          break;
      }
      switch (tangentOutType)
      {
        case CurveTangent.Linear:
          key.TangentOut = num5 - num6;
          break;
        case CurveTangent.Smooth:
          float num10 = num1 - num3;
          float num11 = num5 - num7;
          if ((double) Math.Abs(num11) < 1.19209289550781E-07)
          {
            key.TangentOut = 0.0f;
            break;
          }
          key.TangentOut = num11 * Math.Abs(num1 - num2) / num10;
          break;
        default:
          key.TangentOut = 0.0f;
          break;
      }
    }

    public void ComputeTangents(CurveTangent tangentType)
    {
      int num = (int) tangentType;
      this.ComputeTangents((CurveTangent) num, (CurveTangent) num);
    }

    public void ComputeTangents(CurveTangent tangentInType, CurveTangent tangentOutType)
    {
      for (int keyIndex = 0; keyIndex < this.Keys.Count; ++keyIndex)
        this.ComputeTangent(keyIndex, tangentInType, tangentOutType);
    }

    public float Evaluate(float position)
    {
      if (this.keys.Count == 0)
        return 0.0f;
      if (this.keys.Count == 1)
        return this.keys[0].internalValue;
      CurveKey key1 = this.keys[0];
      CurveKey key2 = this.keys[this.keys.Count - 1];
      float t = position;
      float num1 = 0.0f;
      if ((double) t < (double) key1.position)
      {
        if (this.preLoop == CurveLoopType.Constant)
          return key1.internalValue;
        if (this.preLoop == CurveLoopType.Linear)
          return key1.internalValue - key1.tangentIn * (key1.position - t);
        if (!this.keys.IsCacheAvailable)
          this.keys.ComputeCacheValues();
        float num2 = this.CalcCycle(t);
        float num3 = t - (key1.position + num2 * this.keys.TimeRange);
        if (this.preLoop == CurveLoopType.Cycle)
          t = key1.position + num3;
        else if (this.preLoop == CurveLoopType.CycleOffset)
        {
          t = key1.position + num3;
          num1 = (key2.internalValue - key1.internalValue) * num2;
        }
        else
          t = ((int) num2 & 1) != 0 ? key2.position - num3 : key1.position + num3;
      }
      else if ((double) key2.position < (double) t)
      {
        if (this.postLoop == CurveLoopType.Constant)
          return key2.internalValue;
        if (this.postLoop == CurveLoopType.Linear)
          return key2.internalValue - key2.tangentOut * (key2.position - t);
        if (!this.keys.IsCacheAvailable)
          this.keys.ComputeCacheValues();
        float num2 = this.CalcCycle(t);
        float num3 = t - (key1.position + num2 * this.keys.TimeRange);
        if (this.postLoop == CurveLoopType.Cycle)
          t = key1.position + num3;
        else if (this.postLoop == CurveLoopType.CycleOffset)
        {
          t = key1.position + num3;
          num1 = (key2.internalValue - key1.internalValue) * num2;
        }
        else
          t = ((int) num2 & 1) != 0 ? key2.position - num3 : key1.position + num3;
      }
      CurveKey k0 = (CurveKey) null;
      CurveKey k1 = (CurveKey) null;
      float segment = this.FindSegment(t, ref k0, ref k1);
      return num1 + Curve.Hermite(k0, k1, segment);
    }

    private float CalcCycle(float t)
    {
      float num = (t - this.keys[0].position) * this.keys.InvTimeRange;
      if ((double) num < 0.0)
        --num;
      return (float) (int) num;
    }

    private float FindSegment(float t, ref CurveKey k0, ref CurveKey k1)
    {
      float num1 = t;
      k0 = this.keys[0];
      for (int index = 1; index < this.keys.Count; ++index)
      {
        k1 = this.keys[index];
        if ((double) k1.position >= (double) t)
        {
          double position1 = (double) k0.position;
          double position2 = (double) k1.position;
          double num2 = (double) t;
          double num3 = position1;
          double num4 = position2 - num3;
          num1 = 0.0f;
          if (num4 > 1E-10)
          {
            num1 = (float) ((num2 - position1) / num4);
            break;
          }
          break;
        }
        k0 = k1;
      }
      return num1;
    }

    private static float Hermite(CurveKey k0, CurveKey k1, float t)
    {
      if (k0.Continuity == CurveContinuity.Step)
        return (double) t >= 1.0 ? k1.internalValue : k0.internalValue;
      double num1 = (double) t;
      float num2 = (float) (num1 * num1);
      float num3 = num2 * t;
      double internalValue1 = (double) k0.internalValue;
      float internalValue2 = k1.internalValue;
      float tangentOut = k0.tangentOut;
      float tangentIn = k1.tangentIn;
      double num4 = 2.0 * (double) num3 - 3.0 * (double) num2 + 1.0;
      return (float) (internalValue1 * num4 + (double) internalValue2 * (-2.0 * (double) num3 + 3.0 * (double) num2) + (double) tangentOut * ((double) num3 - 2.0 * (double) num2 + (double) t) + (double) tangentIn * ((double) num3 - (double) num2));
    }
  }
}
