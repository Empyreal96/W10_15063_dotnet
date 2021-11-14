// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IFlightStickStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (FlightStick))]
  [Guid(1427411530, 65228, 17246, 131, 220, 92, 236, 138, 24, 165, 32)]
  internal interface IFlightStickStatics
  {
    event EventHandler<FlightStick> FlightStickAdded;

    event EventHandler<FlightStick> FlightStickRemoved;

    IVectorView<FlightStick> FlightSticks { get; }

    FlightStick FromGameController(IGameController gameController);
  }
}
