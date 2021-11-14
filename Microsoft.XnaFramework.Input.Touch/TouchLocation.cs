// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.Touch.TouchLocation
// Assembly: Microsoft.Xna.Framework.Input.Touch, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 8E9BEFFA-058F-469C-A733-2CE9128BE180
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI3BB0~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.Input.Touch
{
  public struct TouchLocation : IEquatable<TouchLocation>
  {
    private int id;
    private TouchLocationState state;
    private float x;
    private float y;
    private TouchLocationState prevState;
    private float prevX;
    private float prevY;

    public TouchLocation(int id, TouchLocationState state, Vector2 position)
    {
      this.id = id;
      this.state = state;
      this.x = position.X;
      this.y = position.Y;
      this.prevState = TouchLocationState.Invalid;
      this.prevX = 0.0f;
      this.prevY = 0.0f;
    }

    public TouchLocation(
      int id,
      TouchLocationState state,
      Vector2 position,
      TouchLocationState previousState,
      Vector2 previousPosition)
    {
      this.id = id;
      this.state = state;
      this.x = position.X;
      this.y = position.Y;
      this.prevState = previousState;
      this.prevX = previousPosition.X;
      this.prevY = previousPosition.Y;
    }

    public TouchLocationState State => this.state;

    public int Id => this.id;

    public Vector2 Position => new Vector2(this.x, this.y);

    public bool TryGetPreviousLocation(out TouchLocation previousLocation)
    {
      if (this.prevState == TouchLocationState.Invalid)
      {
        previousLocation.id = -1;
        previousLocation.state = TouchLocationState.Invalid;
        previousLocation.x = 0.0f;
        previousLocation.y = 0.0f;
        previousLocation.prevState = TouchLocationState.Invalid;
        previousLocation.prevX = 0.0f;
        previousLocation.prevY = 0.0f;
        return false;
      }
      previousLocation.id = this.id;
      previousLocation.state = this.prevState;
      previousLocation.x = this.prevX;
      previousLocation.y = this.prevY;
      previousLocation.prevState = TouchLocationState.Invalid;
      previousLocation.prevX = 0.0f;
      previousLocation.prevY = 0.0f;
      return true;
    }

    internal TouchLocation(
      int id,
      TouchLocationState state,
      float x,
      float y,
      TouchLocationState prevState,
      float prevX,
      float prevY)
    {
      this.id = id;
      this.state = state;
      this.x = x;
      this.y = y;
      this.prevState = prevState;
      this.prevX = prevX;
      this.prevY = prevY;
    }

    public override string ToString() => string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{{Position:{0}}}", (object) this.Position.ToString());

    public bool Equals(TouchLocation other) => this.id == other.id && (double) this.x == (double) other.x && ((double) this.y == (double) other.y && (double) this.prevX == (double) other.prevX) && (double) this.prevY == (double) other.prevY;

    public override bool Equals(object obj)
    {
      bool flag = false;
      if (obj is TouchLocation other)
        flag = this.Equals(other);
      return flag;
    }

    public override int GetHashCode() => this.id.GetHashCode() + this.x.GetHashCode() + this.y.GetHashCode();

    public static bool operator ==(TouchLocation value1, TouchLocation value2) => value1.id == value2.id && value1.state == value2.state && ((double) value1.x == (double) value2.x && (double) value1.y == (double) value2.y) && (value1.prevState == value2.prevState && (double) value1.prevX == (double) value2.prevX) && (double) value1.prevY == (double) value2.prevY;

    public static bool operator !=(TouchLocation value1, TouchLocation value2) => value1.id != value2.id || value1.state != value2.state || ((double) value1.x != (double) value2.x || (double) value1.y != (double) value2.y) || (value1.prevState != value2.prevState || (double) value1.prevX != (double) value2.prevX) || (double) value1.prevY != (double) value2.prevY;
  }
}
