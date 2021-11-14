// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IProximitySensor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(1421899448, 60667, 18756, 185, 40, 116, 252, 80, 77, 71, 238)]
  [ExclusiveTo(typeof (ProximitySensor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IProximitySensor
  {
    string DeviceId { get; }

    IReference<uint> MaxDistanceInMillimeters { get; }

    IReference<uint> MinDistanceInMillimeters { get; }

    ProximitySensorReading GetCurrentReading();

    event TypedEventHandler<ProximitySensor, ProximitySensorReadingChangedEventArgs> ReadingChanged;

    ProximitySensorDisplayOnOffController CreateDisplayOnOffController();
  }
}
