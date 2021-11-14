// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;

namespace Windows.Devices.WiFiDirect
{
  [ExclusiveTo(typeof (WiFiDirectDevice))]
  [Guid(1927195304, 29419, 19886, 138, 40, 133, 19, 53, 93, 39, 119)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWiFiDirectDevice : IClosable
  {
    WiFiDirectConnectionStatus ConnectionStatus { get; }

    string DeviceId { get; }

    event TypedEventHandler<WiFiDirectDevice, object> ConnectionStatusChanged;

    IVectorView<EndpointPair> GetConnectionEndpointPairs();
  }
}
