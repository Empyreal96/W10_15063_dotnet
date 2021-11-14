// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.GamePadState
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.Input
{
  public struct GamePadState
  {
    private bool _connected;
    private int _packet;
    private GamePadThumbSticks _thumbs;
    private GamePadTriggers _triggers;
    private GamePadButtons _buttons;
    private GamePadDPad _dpad;
    private XINPUT_STATE _state;
    private const int _normalButtonMask = 64511;

    public GamePadState(
      GamePadThumbSticks thumbSticks,
      GamePadTriggers triggers,
      GamePadButtons buttons,
      GamePadDPad dPad)
    {
      this._packet = 0;
      this._connected = true;
      this._thumbs = thumbSticks;
      this._triggers = triggers;
      this._buttons = buttons;
      this._dpad = dPad;
      this._state = new XINPUT_STATE();
      this.FillInternalState();
    }

    public GamePadState(
      Vector2 leftThumbStick,
      Vector2 rightThumbStick,
      float leftTrigger,
      float rightTrigger,
      params Microsoft.Xna.Framework.Input.Buttons[] buttons)
    {
      this._packet = 0;
      this._connected = true;
      this._thumbs = new GamePadThumbSticks(leftThumbStick, rightThumbStick);
      this._triggers = new GamePadTriggers(leftTrigger, rightTrigger);
      Microsoft.Xna.Framework.Input.Buttons buttons1 = (Microsoft.Xna.Framework.Input.Buttons) 0;
      if (buttons != null)
      {
        for (int index = 0; index < buttons.Length; ++index)
          buttons1 |= buttons[index];
      }
      this._buttons = new GamePadButtons(buttons1);
      this._dpad = new GamePadDPad();
      this._dpad._down = (buttons1 & Microsoft.Xna.Framework.Input.Buttons.DPadDown) != (Microsoft.Xna.Framework.Input.Buttons) 0 ? ButtonState.Pressed : ButtonState.Released;
      this._dpad._up = (buttons1 & Microsoft.Xna.Framework.Input.Buttons.DPadUp) != (Microsoft.Xna.Framework.Input.Buttons) 0 ? ButtonState.Pressed : ButtonState.Released;
      this._dpad._left = (buttons1 & Microsoft.Xna.Framework.Input.Buttons.DPadLeft) != (Microsoft.Xna.Framework.Input.Buttons) 0 ? ButtonState.Pressed : ButtonState.Released;
      this._dpad._right = (buttons1 & Microsoft.Xna.Framework.Input.Buttons.DPadRight) != (Microsoft.Xna.Framework.Input.Buttons) 0 ? ButtonState.Pressed : ButtonState.Released;
      this._state = new XINPUT_STATE();
      this.FillInternalState();
    }

    private void FillInternalState()
    {
      this._state.PacketNumber = 0;
      if (this.Buttons.A == ButtonState.Pressed)
        this._state.GamePad.Buttons |= ButtonValues.A;
      GamePadButtons buttons = this.Buttons;
      if (buttons.B == ButtonState.Pressed)
        this._state.GamePad.Buttons |= ButtonValues.B;
      buttons = this.Buttons;
      if (buttons.X == ButtonState.Pressed)
        this._state.GamePad.Buttons |= ButtonValues.X;
      buttons = this.Buttons;
      if (buttons.Y == ButtonState.Pressed)
        this._state.GamePad.Buttons |= ButtonValues.Y;
      buttons = this.Buttons;
      if (buttons.Back == ButtonState.Pressed)
        this._state.GamePad.Buttons |= ButtonValues.Back;
      buttons = this.Buttons;
      if (buttons.LeftShoulder == ButtonState.Pressed)
        this._state.GamePad.Buttons |= ButtonValues.LeftShoulder;
      buttons = this.Buttons;
      if (buttons.LeftStick == ButtonState.Pressed)
        this._state.GamePad.Buttons |= ButtonValues.LeftThumb;
      buttons = this.Buttons;
      if (buttons.RightShoulder == ButtonState.Pressed)
        this._state.GamePad.Buttons |= ButtonValues.RightShoulder;
      buttons = this.Buttons;
      if (buttons.RightStick == ButtonState.Pressed)
        this._state.GamePad.Buttons |= ButtonValues.RightThumb;
      buttons = this.Buttons;
      if (buttons.Start == ButtonState.Pressed)
        this._state.GamePad.Buttons |= ButtonValues.Start;
      buttons = this.Buttons;
      if (buttons.BigButton == ButtonState.Pressed)
        this._state.GamePad.Buttons |= ButtonValues.BigButton;
      GamePadDPad dpad = this.DPad;
      if (dpad.Up == ButtonState.Pressed)
        this._state.GamePad.Buttons |= ButtonValues.Up;
      dpad = this.DPad;
      if (dpad.Down == ButtonState.Pressed)
        this._state.GamePad.Buttons |= ButtonValues.Down;
      dpad = this.DPad;
      if (dpad.Right == ButtonState.Pressed)
        this._state.GamePad.Buttons |= ButtonValues.Right;
      dpad = this.DPad;
      if (dpad.Left == ButtonState.Pressed)
        this._state.GamePad.Buttons |= ButtonValues.Left;
      this._state.GamePad.LeftTrigger = (byte) ((double) this._triggers._left * (double) byte.MaxValue);
      this._state.GamePad.RightTrigger = (byte) ((double) this._triggers._right * (double) byte.MaxValue);
      this._state.GamePad.ThumbLX = (short) ((double) this._thumbs._left.X * (double) short.MaxValue);
      this._state.GamePad.ThumbLY = (short) ((double) this._thumbs._left.Y * (double) short.MaxValue);
      this._state.GamePad.ThumbRX = (short) ((double) this._thumbs._right.X * (double) short.MaxValue);
      this._state.GamePad.ThumbRY = (short) ((double) this._thumbs._right.Y * (double) short.MaxValue);
    }

    internal GamePadState(ref XINPUT_STATE pState, ErrorCodes result, GamePadDeadZone deadZoneMode)
    {
      this._state = pState;
      this._connected = result != ErrorCodes.NotConnected;
      this._packet = pState.PacketNumber;
      this._buttons._a = (pState.GamePad.Buttons & ButtonValues.A) == ButtonValues.A ? ButtonState.Pressed : ButtonState.Released;
      this._buttons._b = (pState.GamePad.Buttons & ButtonValues.B) == ButtonValues.B ? ButtonState.Pressed : ButtonState.Released;
      this._buttons._x = (pState.GamePad.Buttons & ButtonValues.X) == ButtonValues.X ? ButtonState.Pressed : ButtonState.Released;
      this._buttons._y = (pState.GamePad.Buttons & ButtonValues.Y) == ButtonValues.Y ? ButtonState.Pressed : ButtonState.Released;
      this._buttons._start = (pState.GamePad.Buttons & ButtonValues.Start) == ButtonValues.Start ? ButtonState.Pressed : ButtonState.Released;
      this._buttons._back = (pState.GamePad.Buttons & ButtonValues.Back) == ButtonValues.Back ? ButtonState.Pressed : ButtonState.Released;
      this._buttons._leftStick = (pState.GamePad.Buttons & ButtonValues.LeftThumb) == ButtonValues.LeftThumb ? ButtonState.Pressed : ButtonState.Released;
      this._buttons._rightStick = (pState.GamePad.Buttons & ButtonValues.RightThumb) == ButtonValues.RightThumb ? ButtonState.Pressed : ButtonState.Released;
      this._buttons._leftShoulder = (pState.GamePad.Buttons & ButtonValues.LeftShoulder) == ButtonValues.LeftShoulder ? ButtonState.Pressed : ButtonState.Released;
      this._buttons._rightShoulder = (pState.GamePad.Buttons & ButtonValues.RightShoulder) == ButtonValues.RightShoulder ? ButtonState.Pressed : ButtonState.Released;
      this._buttons._bigButton = (pState.GamePad.Buttons & ButtonValues.BigButton) == ButtonValues.BigButton ? ButtonState.Pressed : ButtonState.Released;
      this._triggers._left = GamePadDeadZoneUtils.ApplyTriggerDeadZone((int) pState.GamePad.LeftTrigger, deadZoneMode);
      this._triggers._right = GamePadDeadZoneUtils.ApplyTriggerDeadZone((int) pState.GamePad.RightTrigger, deadZoneMode);
      this._thumbs._left = GamePadDeadZoneUtils.ApplyLeftStickDeadZone((int) pState.GamePad.ThumbLX, (int) pState.GamePad.ThumbLY, deadZoneMode);
      this._thumbs._right = GamePadDeadZoneUtils.ApplyRightStickDeadZone((int) pState.GamePad.ThumbRX, (int) pState.GamePad.ThumbRY, deadZoneMode);
      this._dpad._down = (pState.GamePad.Buttons & ButtonValues.Down) == ButtonValues.Down ? ButtonState.Pressed : ButtonState.Released;
      this._dpad._up = (pState.GamePad.Buttons & ButtonValues.Up) == ButtonValues.Up ? ButtonState.Pressed : ButtonState.Released;
      this._dpad._left = (pState.GamePad.Buttons & ButtonValues.Left) == ButtonValues.Left ? ButtonState.Pressed : ButtonState.Released;
      this._dpad._right = (pState.GamePad.Buttons & ButtonValues.Right) == ButtonValues.Right ? ButtonState.Pressed : ButtonState.Released;
    }

    public GamePadButtons Buttons => this._buttons;

    public GamePadDPad DPad => this._dpad;

    public bool IsConnected => this._connected;

    public int PacketNumber => this._packet;

    public GamePadThumbSticks ThumbSticks => this._thumbs;

    public GamePadTriggers Triggers => this._triggers;

    public bool IsButtonDown(Microsoft.Xna.Framework.Input.Buttons button)
    {
      Microsoft.Xna.Framework.Input.Buttons buttons = (Microsoft.Xna.Framework.Input.Buttons) (this._state.GamePad.Buttons & (ButtonValues.A | ButtonValues.B | ButtonValues.Back | ButtonValues.Down | ButtonValues.Left | ButtonValues.LeftShoulder | ButtonValues.LeftThumb | ButtonValues.Right | ButtonValues.RightShoulder | ButtonValues.RightThumb | ButtonValues.Start | ButtonValues.Up | ButtonValues.X | ButtonValues.Y | ButtonValues.BigButton));
      if ((button & Microsoft.Xna.Framework.Input.Buttons.LeftThumbstickLeft) == Microsoft.Xna.Framework.Input.Buttons.LeftThumbstickLeft && (double) GamePadDeadZoneUtils.ApplyLeftStickDeadZone((int) this._state.GamePad.ThumbLX, (int) this._state.GamePad.ThumbLY, GamePadDeadZone.IndependentAxes).X < 0.0)
        buttons |= Microsoft.Xna.Framework.Input.Buttons.LeftThumbstickLeft;
      if ((button & Microsoft.Xna.Framework.Input.Buttons.LeftThumbstickRight) == Microsoft.Xna.Framework.Input.Buttons.LeftThumbstickRight && (double) GamePadDeadZoneUtils.ApplyLeftStickDeadZone((int) this._state.GamePad.ThumbLX, (int) this._state.GamePad.ThumbLY, GamePadDeadZone.IndependentAxes).X > 0.0)
        buttons |= Microsoft.Xna.Framework.Input.Buttons.LeftThumbstickRight;
      if ((button & Microsoft.Xna.Framework.Input.Buttons.LeftThumbstickDown) == Microsoft.Xna.Framework.Input.Buttons.LeftThumbstickDown && (double) GamePadDeadZoneUtils.ApplyLeftStickDeadZone((int) this._state.GamePad.ThumbLX, (int) this._state.GamePad.ThumbLY, GamePadDeadZone.IndependentAxes).Y < 0.0)
        buttons |= Microsoft.Xna.Framework.Input.Buttons.LeftThumbstickDown;
      if ((button & Microsoft.Xna.Framework.Input.Buttons.LeftThumbstickUp) == Microsoft.Xna.Framework.Input.Buttons.LeftThumbstickUp && (double) GamePadDeadZoneUtils.ApplyLeftStickDeadZone((int) this._state.GamePad.ThumbLX, (int) this._state.GamePad.ThumbLY, GamePadDeadZone.IndependentAxes).Y > 0.0)
        buttons |= Microsoft.Xna.Framework.Input.Buttons.LeftThumbstickUp;
      if ((button & Microsoft.Xna.Framework.Input.Buttons.RightThumbstickLeft) == Microsoft.Xna.Framework.Input.Buttons.RightThumbstickLeft && (double) GamePadDeadZoneUtils.ApplyRightStickDeadZone((int) this._state.GamePad.ThumbRX, (int) this._state.GamePad.ThumbRY, GamePadDeadZone.IndependentAxes).X < 0.0)
        buttons |= Microsoft.Xna.Framework.Input.Buttons.RightThumbstickLeft;
      if ((button & Microsoft.Xna.Framework.Input.Buttons.RightThumbstickRight) == Microsoft.Xna.Framework.Input.Buttons.RightThumbstickRight && (double) GamePadDeadZoneUtils.ApplyRightStickDeadZone((int) this._state.GamePad.ThumbRX, (int) this._state.GamePad.ThumbRY, GamePadDeadZone.IndependentAxes).X > 0.0)
        buttons |= Microsoft.Xna.Framework.Input.Buttons.RightThumbstickRight;
      if ((button & Microsoft.Xna.Framework.Input.Buttons.RightThumbstickDown) == Microsoft.Xna.Framework.Input.Buttons.RightThumbstickDown && (double) GamePadDeadZoneUtils.ApplyRightStickDeadZone((int) this._state.GamePad.ThumbRX, (int) this._state.GamePad.ThumbRY, GamePadDeadZone.IndependentAxes).Y < 0.0)
        buttons |= Microsoft.Xna.Framework.Input.Buttons.RightThumbstickDown;
      if ((button & Microsoft.Xna.Framework.Input.Buttons.RightThumbstickUp) == Microsoft.Xna.Framework.Input.Buttons.RightThumbstickUp && (double) GamePadDeadZoneUtils.ApplyRightStickDeadZone((int) this._state.GamePad.ThumbRX, (int) this._state.GamePad.ThumbRY, GamePadDeadZone.IndependentAxes).Y > 0.0)
        buttons |= Microsoft.Xna.Framework.Input.Buttons.RightThumbstickUp;
      if ((button & Microsoft.Xna.Framework.Input.Buttons.LeftTrigger) == Microsoft.Xna.Framework.Input.Buttons.LeftTrigger && (double) GamePadDeadZoneUtils.ApplyTriggerDeadZone((int) this._state.GamePad.LeftTrigger, GamePadDeadZone.IndependentAxes) > 0.0)
        buttons |= Microsoft.Xna.Framework.Input.Buttons.LeftTrigger;
      if ((button & Microsoft.Xna.Framework.Input.Buttons.RightTrigger) == Microsoft.Xna.Framework.Input.Buttons.RightTrigger && (double) GamePadDeadZoneUtils.ApplyTriggerDeadZone((int) this._state.GamePad.RightTrigger, GamePadDeadZone.IndependentAxes) > 0.0)
        buttons |= Microsoft.Xna.Framework.Input.Buttons.RightTrigger;
      return (button & buttons) == button;
    }

    public bool IsButtonUp(Microsoft.Xna.Framework.Input.Buttons button) => !this.IsButtonDown(button);

    public override bool Equals(object obj) => obj != null && obj.GetType() == this.GetType() && this == (GamePadState) obj;

    public override int GetHashCode() => this._thumbs.GetHashCode() ^ this._triggers.GetHashCode() ^ (this._buttons.GetHashCode() ^ this._connected.GetHashCode()) ^ (this._dpad.GetHashCode() ^ this._packet.GetHashCode());

    public override string ToString() => string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{{IsConnected:{0}}}", (object) this._connected);

    public static bool operator ==(GamePadState left, GamePadState right) => left._connected == right._connected && left._packet == right._packet && (left._thumbs == right._thumbs && left._triggers == right._triggers) && left._buttons == right._buttons && left._dpad == right._dpad;

    public static bool operator !=(GamePadState left, GamePadState right) => left._connected != right._connected || left._packet != right._packet || (left._thumbs != right._thumbs || left._triggers != right._triggers) || left._buttons != right._buttons || left._dpad != right._dpad;
  }
}
