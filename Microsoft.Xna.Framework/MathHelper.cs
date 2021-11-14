// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.MathHelper
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;

namespace Microsoft.Xna.Framework
{
  public static class MathHelper
  {
    public const float E = 2.718282f;
    public const float Log2E = 1.442695f;
    public const float Log10E = 0.4342945f;
    public const float Pi = 3.141593f;
    public const float TwoPi = 6.283185f;
    public const float PiOver2 = 1.570796f;
    public const float PiOver4 = 0.7853982f;

    public static float ToRadians(float degrees) => degrees * ((float) Math.PI / 180f);

    public static float ToDegrees(float radians) => radians * 57.29578f;

    public static float Distance(float value1, float value2) => Math.Abs(value1 - value2);

    public static float Min(float value1, float value2) => Math.Min(value1, value2);

    public static float Max(float value1, float value2) => Math.Max(value1, value2);

    public static float Clamp(float value, float min, float max)
    {
      value = (double) value > (double) max ? max : value;
      value = (double) value < (double) min ? min : value;
      return value;
    }

    public static float Lerp(float value1, float value2, float amount) => value1 + (value2 - value1) * amount;

    public static float Barycentric(
      float value1,
      float value2,
      float value3,
      float amount1,
      float amount2)
    {
      return (float) ((double) value1 + (double) amount1 * ((double) value2 - (double) value1) + (double) amount2 * ((double) value3 - (double) value1));
    }

    public static float SmoothStep(float value1, float value2, float amount)
    {
      float num1 = MathHelper.Clamp(amount, 0.0f, 1f);
      double num2 = (double) value1;
      double num3 = (double) value2;
      double num4 = (double) num1;
      double num5 = num4 * num4 * (3.0 - 2.0 * (double) num1);
      return MathHelper.Lerp((float) num2, (float) num3, (float) num5);
    }

    public static float CatmullRom(
      float value1,
      float value2,
      float value3,
      float value4,
      float amount)
    {
      double num1 = (double) amount;
      float num2 = (float) (num1 * num1);
      float num3 = amount * num2;
      return (float) (0.5 * (2.0 * (double) value2 + (-(double) value1 + (double) value3) * (double) amount + (2.0 * (double) value1 - 5.0 * (double) value2 + 4.0 * (double) value3 - (double) value4) * (double) num2 + (-(double) value1 + 3.0 * (double) value2 - 3.0 * (double) value3 + (double) value4) * (double) num3));
    }

    public static float Hermite(
      float value1,
      float tangent1,
      float value2,
      float tangent2,
      float amount)
    {
      float num1 = amount;
      double num2 = (double) num1;
      float num3 = (float) (num2 * num2);
      float num4 = num1 * num3;
      float num5 = (float) (2.0 * (double) num4 - 3.0 * (double) num3 + 1.0);
      float num6 = (float) (-2.0 * (double) num4 + 3.0 * (double) num3);
      float num7 = num4 - 2f * num3 + num1;
      float num8 = num4 - num3;
      return (float) ((double) value1 * (double) num5 + (double) value2 * (double) num6 + (double) tangent1 * (double) num7 + (double) tangent2 * (double) num8);
    }

    public static float WrapAngle(float angle)
    {
      angle = (float) Math.IEEERemainder((double) angle, 6.28318548202515);
      if ((double) angle <= -3.14159274101257)
        angle += 6.283185f;
      else if ((double) angle > 3.14159274101257)
        angle -= 6.283185f;
      return angle;
    }
  }
}
