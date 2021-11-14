// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IGamepad2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [Guid(1008110013, 22805, 16965, 176, 192, 200, 159, 174, 3, 8, 255)]
  [ExclusiveTo(typeof (Gamepad))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IGamepad2 : IGamepad, IGameController
  {
    GameControllerButtonLabel GetButtonLabel(GamepadButtons button);
  }
}
