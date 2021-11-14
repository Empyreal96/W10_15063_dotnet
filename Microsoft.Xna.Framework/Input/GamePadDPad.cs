// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.GamePadDPad
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.Input
{
  public struct GamePadDPad
  {
    internal ButtonState _up;
    internal ButtonState _right;
    internal ButtonState _down;
    internal ButtonState _left;

    public GamePadDPad(
      ButtonState upValue,
      ButtonState downValue,
      ButtonState leftValue,
      ButtonState rightValue)
    {
      this._up = upValue;
      this._right = rightValue;
      this._down = downValue;
      this._left = leftValue;
    }

    public ButtonState Up => this._up;

    public ButtonState Down => this._down;

    public ButtonState Right => this._right;

    public ButtonState Left => this._left;

    public override bool Equals(object obj) => obj != null && obj.GetType() == this.GetType() && this == (GamePadDPad) obj;

    public override int GetHashCode() => Helpers.SmartGetHashCode((object) this);

    public override string ToString()
    {
      string str1 = string.Empty;
      if (this._up == ButtonState.Pressed)
      {
        string str2 = str1;
        str1 = str2 + (str2.Length != 0 ? " " : "") + "Up";
      }
      if (this._down == ButtonState.Pressed)
      {
        string str2 = str1;
        str1 = str2 + (str2.Length != 0 ? " " : "") + "Down";
      }
      if (this._left == ButtonState.Pressed)
      {
        string str2 = str1;
        str1 = str2 + (str2.Length != 0 ? " " : "") + "Left";
      }
      if (this._right == ButtonState.Pressed)
      {
        string str2 = str1;
        str1 = str2 + (str2.Length != 0 ? " " : "") + "Right";
      }
      if (str1.Length == 0)
        str1 = "None";
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{{DPad:{0}}}", (object) str1);
    }

    public static bool operator ==(GamePadDPad left, GamePadDPad right) => left._up == right._up && left._down == right._down && left._left == right._left && left._right == right._right;

    public static bool operator !=(GamePadDPad left, GamePadDPad right) => left._up != right._up || left._down != right._down || left._left != right._left || left._right != right._right;
  }
}
