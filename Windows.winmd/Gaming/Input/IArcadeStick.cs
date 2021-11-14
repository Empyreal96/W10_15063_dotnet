// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IArcadeStick
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2974438301, 48891, 19585, 128, 81, 21, 236, 243, 177, 48, 54)]
  [ExclusiveTo(typeof (ArcadeStick))]
  internal interface IArcadeStick : IGameController
  {
    GameControllerButtonLabel GetButtonLabel(ArcadeStickButtons button);

    ArcadeStickReading GetCurrentReading();
  }
}
