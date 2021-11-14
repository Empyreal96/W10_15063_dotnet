// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.GamePad
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

namespace Microsoft.Xna.Framework.Input
{
  public static class GamePad
  {
    internal static bool backButtonPressed;

    public static GamePadState GetState(PlayerIndex playerIndex) => GamePad.GetState(playerIndex, GamePadDeadZone.None);

    public static GamePadState GetState(
      PlayerIndex playerIndex,
      GamePadDeadZone deadZoneMode)
    {
      XINPUT_STATE pState = new XINPUT_STATE();
      pState.GamePad.Buttons |= GamePad.backButtonPressed ? ButtonValues.Back : (ButtonValues) 0;
      return new GamePadState(ref pState, ErrorCodes.NotConnected, GamePadDeadZone.None);
    }

    public static GamePadCapabilities GetCapabilities(PlayerIndex playerIndex)
    {
      XINPUT_CAPABILITIES caps = new XINPUT_CAPABILITIES();
      return new GamePadCapabilities(ref caps, ErrorCodes.NotConnected);
    }

    public static bool SetVibration(PlayerIndex playerIndex, float leftMotor, float rightMotor) => false;
  }
}
