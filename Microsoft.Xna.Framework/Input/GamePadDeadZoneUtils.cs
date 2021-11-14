// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.GamePadDeadZoneUtils
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;

namespace Microsoft.Xna.Framework.Input
{
  internal static class GamePadDeadZoneUtils
  {
    private const int LeftStickDeadZoneSize = 7849;
    private const int RightStickDeadZoneSize = 8689;
    private const int TriggerDeadZoneSize = 30;

    internal static Vector2 ApplyLeftStickDeadZone(
      int x,
      int y,
      GamePadDeadZone deadZoneMode)
    {
      return GamePadDeadZoneUtils.ApplyStickDeadZone(x, y, deadZoneMode, 7849);
    }

    internal static Vector2 ApplyRightStickDeadZone(
      int x,
      int y,
      GamePadDeadZone deadZoneMode)
    {
      return GamePadDeadZoneUtils.ApplyStickDeadZone(x, y, deadZoneMode, 8689);
    }

    private static Vector2 ApplyStickDeadZone(
      int x,
      int y,
      GamePadDeadZone deadZoneMode,
      int deadZoneSize)
    {
      Vector2 vector2;
      switch (deadZoneMode)
      {
        case GamePadDeadZone.IndependentAxes:
          vector2.X = GamePadDeadZoneUtils.ApplyLinearDeadZone((float) x, (float) short.MaxValue, (float) deadZoneSize);
          vector2.Y = GamePadDeadZoneUtils.ApplyLinearDeadZone((float) y, (float) short.MaxValue, (float) deadZoneSize);
          break;
        case GamePadDeadZone.Circular:
          int num1 = x;
          int num2 = num1 * num1;
          int num3 = y;
          int num4 = num3 * num3;
          float num5 = (float) Math.Sqrt((double) (num2 + num4));
          float num6 = GamePadDeadZoneUtils.ApplyLinearDeadZone(num5, (float) short.MaxValue, (float) deadZoneSize);
          float num7 = (double) num6 > 0.0 ? num6 / num5 : 0.0f;
          vector2.X = MathHelper.Clamp((float) x * num7, -1f, 1f);
          vector2.Y = MathHelper.Clamp((float) y * num7, -1f, 1f);
          break;
        default:
          vector2.X = GamePadDeadZoneUtils.ApplyLinearDeadZone((float) x, (float) short.MaxValue, 0.0f);
          vector2.Y = GamePadDeadZoneUtils.ApplyLinearDeadZone((float) y, (float) short.MaxValue, 0.0f);
          break;
      }
      return vector2;
    }

    internal static float ApplyTriggerDeadZone(int value, GamePadDeadZone deadZoneMode) => deadZoneMode == GamePadDeadZone.None ? GamePadDeadZoneUtils.ApplyLinearDeadZone((float) value, (float) byte.MaxValue, 0.0f) : GamePadDeadZoneUtils.ApplyLinearDeadZone((float) value, (float) byte.MaxValue, 30f);

    private static float ApplyLinearDeadZone(float value, float maxValue, float deadZoneSize)
    {
      if ((double) value < -(double) deadZoneSize)
      {
        value += deadZoneSize;
      }
      else
      {
        if ((double) value <= (double) deadZoneSize)
          return 0.0f;
        value -= deadZoneSize;
      }
      return MathHelper.Clamp(value / (maxValue - deadZoneSize), -1f, 1f);
    }
  }
}
