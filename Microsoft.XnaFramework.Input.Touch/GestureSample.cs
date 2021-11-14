// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.Touch.GestureSample
// Assembly: Microsoft.Xna.Framework.Input.Touch, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 8E9BEFFA-058F-469C-A733-2CE9128BE180
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI3BB0~1.DLL

using System;

namespace Microsoft.Xna.Framework.Input.Touch
{
  public struct GestureSample
  {
    internal GestureType _gestureType;
    internal TimeSpan _timestamp;
    internal Vector2 _position;
    internal Vector2 _position2;
    internal Vector2 _delta;
    internal Vector2 _delta2;

    public GestureSample(
      GestureType gestureType,
      TimeSpan timestamp,
      Vector2 position,
      Vector2 position2,
      Vector2 delta,
      Vector2 delta2)
    {
      this._gestureType = gestureType;
      this._timestamp = timestamp;
      this._position = position;
      this._position2 = position2;
      this._delta = delta;
      this._delta2 = delta2;
    }

    public GestureType GestureType => this._gestureType;

    public TimeSpan Timestamp => this._timestamp;

    public Vector2 Position => this._position;

    public Vector2 Position2 => this._position2;

    public Vector2 Delta => this._delta;

    public Vector2 Delta2 => this._delta2;
  }
}
