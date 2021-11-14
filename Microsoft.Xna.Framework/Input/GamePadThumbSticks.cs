// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.GamePadThumbSticks
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.Input
{
  public struct GamePadThumbSticks
  {
    internal Vector2 _left;
    internal Vector2 _right;

    public GamePadThumbSticks(Vector2 leftThumbstick, Vector2 rightThumbstick)
    {
      this._left = leftThumbstick;
      this._right = rightThumbstick;
      this._left = Vector2.Min(this._left, Vector2.One);
      this._left = Vector2.Max(this._left, -Vector2.One);
      this._right = Vector2.Min(this._right, Vector2.One);
      this._right = Vector2.Max(this._right, -Vector2.One);
    }

    public Vector2 Left => this._left;

    public Vector2 Right => this._right;

    public override bool Equals(object obj) => obj != null && obj.GetType() == this.GetType() && this == (GamePadThumbSticks) obj;

    public override int GetHashCode() => Helpers.SmartGetHashCode((object) this);

    public override string ToString() => string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{{Left:{0} Right:{1}}}", (object) this._left, (object) this._right);

    public static bool operator ==(GamePadThumbSticks left, GamePadThumbSticks right) => left._left == right._left && left._right == right._right;

    public static bool operator !=(GamePadThumbSticks left, GamePadThumbSticks right) => left._left != right._left || left._right != right._right;
  }
}
