// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.MouseState
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.Input
{
  public struct MouseState
  {
    internal int x;
    internal int y;
    internal ButtonState leftButton;
    internal ButtonState rightButton;
    internal ButtonState middleButton;
    internal ButtonState xb1;
    internal ButtonState xb2;
    internal int wheel;

    public MouseState(
      int x,
      int y,
      int scrollWheel,
      ButtonState leftButton,
      ButtonState middleButton,
      ButtonState rightButton,
      ButtonState xButton1,
      ButtonState xButton2)
    {
      this.x = x;
      this.y = y;
      this.wheel = scrollWheel;
      this.leftButton = leftButton;
      this.rightButton = rightButton;
      this.middleButton = middleButton;
      this.xb1 = xButton1;
      this.xb2 = xButton2;
    }

    public int X => this.x;

    public int Y => this.y;

    public ButtonState LeftButton => this.leftButton;

    public ButtonState RightButton => this.rightButton;

    public ButtonState MiddleButton => this.middleButton;

    public ButtonState XButton1 => this.xb1;

    public ButtonState XButton2 => this.xb2;

    public int ScrollWheelValue => this.wheel;

    public override int GetHashCode() => this.x.GetHashCode() ^ this.y.GetHashCode() ^ this.leftButton.GetHashCode() ^ this.rightButton.GetHashCode() ^ this.middleButton.GetHashCode() ^ this.xb1.GetHashCode() ^ this.xb2.GetHashCode() ^ this.wheel.GetHashCode();

    public override string ToString()
    {
      string str = string.Empty;
      if (this.leftButton == ButtonState.Pressed)
        str = str + (string.IsNullOrEmpty(str) ? "" : " ") + "Left";
      if (this.rightButton == ButtonState.Pressed)
        str = str + (string.IsNullOrEmpty(str) ? "" : " ") + "Right";
      if (this.middleButton == ButtonState.Pressed)
        str = str + (string.IsNullOrEmpty(str) ? "" : " ") + "Middle";
      if (this.xb1 == ButtonState.Pressed)
        str = str + (string.IsNullOrEmpty(str) ? "" : " ") + "XButton1";
      if (this.xb2 == ButtonState.Pressed)
        str = str + (string.IsNullOrEmpty(str) ? "" : " ") + "XButton2";
      if (string.IsNullOrEmpty(str))
        str = "None";
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{{X:{0} Y:{1} Buttons:{2} Wheel:{3}}}", (object) this.x, (object) this.y, (object) str, (object) this.wheel);
    }

    public override bool Equals(object obj) => obj is MouseState mouseState && this == mouseState;

    public static bool operator ==(MouseState left, MouseState right) => left.x == right.x && left.y == right.y && (left.leftButton == right.leftButton && left.rightButton == right.rightButton) && (left.middleButton == right.middleButton && left.xb1 == right.xb1 && left.xb2 == right.xb2) && left.wheel == right.wheel;

    public static bool operator !=(MouseState left, MouseState right) => !(left == right);
  }
}
