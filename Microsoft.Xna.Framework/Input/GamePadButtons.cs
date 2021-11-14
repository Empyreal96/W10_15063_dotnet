// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.GamePadButtons
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.Input
{
  public struct GamePadButtons
  {
    internal ButtonState _a;
    internal ButtonState _b;
    internal ButtonState _x;
    internal ButtonState _y;
    internal ButtonState _leftStick;
    internal ButtonState _rightStick;
    internal ButtonState _leftShoulder;
    internal ButtonState _rightShoulder;
    internal ButtonState _back;
    internal ButtonState _start;
    internal ButtonState _bigButton;

    public GamePadButtons(Buttons buttons)
    {
      this._a = (buttons & Buttons.A) == Buttons.A ? ButtonState.Pressed : ButtonState.Released;
      this._b = (buttons & Buttons.B) == Buttons.B ? ButtonState.Pressed : ButtonState.Released;
      this._x = (buttons & Buttons.X) == Buttons.X ? ButtonState.Pressed : ButtonState.Released;
      this._y = (buttons & Buttons.Y) == Buttons.Y ? ButtonState.Pressed : ButtonState.Released;
      this._start = (buttons & Buttons.Start) == Buttons.Start ? ButtonState.Pressed : ButtonState.Released;
      this._back = (buttons & Buttons.Back) == Buttons.Back ? ButtonState.Pressed : ButtonState.Released;
      this._leftStick = (buttons & Buttons.LeftStick) == Buttons.LeftStick ? ButtonState.Pressed : ButtonState.Released;
      this._rightStick = (buttons & Buttons.RightStick) == Buttons.RightStick ? ButtonState.Pressed : ButtonState.Released;
      this._leftShoulder = (buttons & Buttons.LeftShoulder) == Buttons.LeftShoulder ? ButtonState.Pressed : ButtonState.Released;
      this._rightShoulder = (buttons & Buttons.RightShoulder) == Buttons.RightShoulder ? ButtonState.Pressed : ButtonState.Released;
      this._bigButton = (buttons & Buttons.BigButton) == Buttons.BigButton ? ButtonState.Pressed : ButtonState.Released;
    }

    public ButtonState A => this._a;

    public ButtonState B => this._b;

    public ButtonState Back => this._back;

    public ButtonState X => this._x;

    public ButtonState Y => this._y;

    public ButtonState Start => this._start;

    public ButtonState LeftShoulder => this._leftShoulder;

    public ButtonState LeftStick => this._leftStick;

    public ButtonState RightShoulder => this._rightShoulder;

    public ButtonState RightStick => this._rightStick;

    public ButtonState BigButton => this._bigButton;

    public override bool Equals(object obj) => obj != null && obj.GetType() == this.GetType() && this == (GamePadButtons) obj;

    public override int GetHashCode() => Helpers.SmartGetHashCode((object) this);

    public override string ToString()
    {
      string str1 = string.Empty;
      if (this._a == ButtonState.Pressed)
      {
        string str2 = str1;
        str1 = str2 + (str2.Length != 0 ? " " : "") + "A";
      }
      if (this._b == ButtonState.Pressed)
      {
        string str2 = str1;
        str1 = str2 + (str2.Length != 0 ? " " : "") + "B";
      }
      if (this._x == ButtonState.Pressed)
      {
        string str2 = str1;
        str1 = str2 + (str2.Length != 0 ? " " : "") + "X";
      }
      if (this._y == ButtonState.Pressed)
      {
        string str2 = str1;
        str1 = str2 + (str2.Length != 0 ? " " : "") + "Y";
      }
      if (this._leftShoulder == ButtonState.Pressed)
      {
        string str2 = str1;
        str1 = str2 + (str2.Length != 0 ? " " : "") + "LeftShoulder";
      }
      if (this._rightShoulder == ButtonState.Pressed)
      {
        string str2 = str1;
        str1 = str2 + (str2.Length != 0 ? " " : "") + "RightShoulder";
      }
      if (this._leftStick == ButtonState.Pressed)
      {
        string str2 = str1;
        str1 = str2 + (str2.Length != 0 ? " " : "") + "LeftStick";
      }
      if (this._rightStick == ButtonState.Pressed)
      {
        string str2 = str1;
        str1 = str2 + (str2.Length != 0 ? " " : "") + "RightStick";
      }
      if (this._start == ButtonState.Pressed)
      {
        string str2 = str1;
        str1 = str2 + (str2.Length != 0 ? " " : "") + "Start";
      }
      if (this._back == ButtonState.Pressed)
      {
        string str2 = str1;
        str1 = str2 + (str2.Length != 0 ? " " : "") + "Back";
      }
      if (this._bigButton == ButtonState.Pressed)
      {
        string str2 = str1;
        str1 = str2 + (str2.Length != 0 ? " " : "") + "BigButton";
      }
      if (str1.Length == 0)
        str1 = "None";
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{{Buttons:{0}}}", (object) str1);
    }

    public static bool operator ==(GamePadButtons left, GamePadButtons right) => left._a == right._a && left._b == right._b && (left._x == right._x && left._y == right._y) && (left._leftShoulder == right._leftShoulder && left._leftStick == right._leftStick && (left._rightShoulder == right._rightShoulder && left._rightStick == right._rightStick)) && (left._back == right._back && left._start == right._start) && left._bigButton == right._bigButton;

    public static bool operator !=(GamePadButtons left, GamePadButtons right) => left._a != right._a || left._b != right._b || (left._x != right._x || left._y != right._y) || (left._leftShoulder != right._leftShoulder || left._leftStick != right._leftStick || (left._rightShoulder != right._rightShoulder || left._rightStick != right._rightStick)) || (left._back != right._back || left._start != right._start) || left._bigButton != right._bigButton;
  }
}
