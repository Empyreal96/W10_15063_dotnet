// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.GamePadTriggers
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.Input
{
  public struct GamePadTriggers
  {
    internal float _left;
    internal float _right;

    public GamePadTriggers(float leftTrigger, float rightTrigger)
    {
      this._left = leftTrigger;
      this._right = rightTrigger;
      this._left = Math.Min(this._left, 1f);
      this._left = Math.Max(this._left, 0.0f);
      this._right = Math.Min(this._right, 1f);
      this._right = Math.Max(this._right, 0.0f);
    }

    public float Left => this._left;

    public float Right => this._right;

    public override bool Equals(object obj) => obj != null && obj.GetType() == this.GetType() && this == (GamePadTriggers) obj;

    public override int GetHashCode() => Helpers.SmartGetHashCode((object) this);

    public override string ToString() => string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{{Left:{0} Right:{1}}}", (object) this._left, (object) this._right);

    public static bool operator ==(GamePadTriggers left, GamePadTriggers right) => (double) left._left == (double) right._left && (double) left._right == (double) right._right;

    public static bool operator !=(GamePadTriggers left, GamePadTriggers right) => (double) left._left != (double) right._left || (double) left._right != (double) right._right;
  }
}
