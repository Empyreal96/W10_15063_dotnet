// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IFlightStick
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [Guid(3030564892, 47163, 17497, 161, 169, 151, 176, 60, 51, 218, 124)]
  [ExclusiveTo(typeof (FlightStick))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IFlightStick : IGameController
  {
    GameControllerSwitchKind HatSwitchKind { get; }

    GameControllerButtonLabel GetButtonLabel(FlightStickButtons button);

    FlightStickReading GetCurrentReading();
  }
}
