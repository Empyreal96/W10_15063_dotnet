// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.GamePadCapabilities
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Xna.Framework.Input
{
  [SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes")]
  public struct GamePadCapabilities
  {
    private bool _connected;
    private XINPUT_CAPABILITIES _caps;

    internal GamePadCapabilities(ref XINPUT_CAPABILITIES caps, ErrorCodes result)
    {
      this._connected = result != ErrorCodes.NotConnected;
      this._caps = caps;
    }

    public GamePadType GamePadType => this._caps.Type == (byte) 3 ? (GamePadType) ((int) this._caps.Type << 8 | (int) this._caps.SubType) : (GamePadType) this._caps.SubType;

    public bool IsConnected => this._connected;

    public bool HasAButton => (uint) (this._caps.GamePad.Buttons & ButtonValues.A) > 0U;

    public bool HasBackButton => (uint) (this._caps.GamePad.Buttons & ButtonValues.Back) > 0U;

    public bool HasBButton => (uint) (this._caps.GamePad.Buttons & ButtonValues.B) > 0U;

    public bool HasDPadDownButton => (uint) (this._caps.GamePad.Buttons & ButtonValues.Down) > 0U;

    public bool HasDPadLeftButton => (uint) (this._caps.GamePad.Buttons & ButtonValues.Left) > 0U;

    public bool HasDPadRightButton => (uint) (this._caps.GamePad.Buttons & ButtonValues.Right) > 0U;

    public bool HasDPadUpButton => (uint) (this._caps.GamePad.Buttons & ButtonValues.Up) > 0U;

    public bool HasLeftShoulderButton => (uint) (this._caps.GamePad.Buttons & ButtonValues.LeftShoulder) > 0U;

    public bool HasLeftStickButton => (uint) (this._caps.GamePad.Buttons & ButtonValues.LeftThumb) > 0U;

    public bool HasRightShoulderButton => (uint) (this._caps.GamePad.Buttons & ButtonValues.RightShoulder) > 0U;

    public bool HasRightStickButton => (uint) (this._caps.GamePad.Buttons & ButtonValues.RightThumb) > 0U;

    public bool HasStartButton => (uint) (this._caps.GamePad.Buttons & ButtonValues.Start) > 0U;

    public bool HasXButton => (uint) (this._caps.GamePad.Buttons & ButtonValues.X) > 0U;

    public bool HasYButton => (uint) (this._caps.GamePad.Buttons & ButtonValues.Y) > 0U;

    public bool HasBigButton => (uint) (this._caps.GamePad.Buttons & ButtonValues.BigButton) > 0U;

    public bool HasLeftXThumbStick => (uint) this._caps.GamePad.ThumbLX > 0U;

    public bool HasLeftYThumbStick => (uint) this._caps.GamePad.ThumbLY > 0U;

    public bool HasRightXThumbStick => (uint) this._caps.GamePad.ThumbRX > 0U;

    public bool HasRightYThumbStick => (uint) this._caps.GamePad.ThumbRY > 0U;

    public bool HasLeftTrigger => this._caps.GamePad.LeftTrigger > (byte) 0;

    public bool HasRightTrigger => this._caps.GamePad.RightTrigger > (byte) 0;

    public bool HasLeftVibrationMotor => (uint) this._caps.Vibration.LeftMotorSpeed > 0U;

    public bool HasRightVibrationMotor => (uint) this._caps.Vibration.RightMotorSpeed > 0U;

    public bool HasVoiceSupport => ((uint) this._caps.Flags & 4U) > 0U;
  }
}
