// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFi.IWiFiAdapter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;
using Windows.Security.Credentials;

namespace Windows.Devices.WiFi
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2797921315, 15733, 17316, 185, 222, 17, 226, 107, 114, 217, 176)]
  [ExclusiveTo(typeof (WiFiAdapter))]
  internal interface IWiFiAdapter
  {
    NetworkAdapter NetworkAdapter { get; }

    [RemoteAsync]
    IAsyncAction ScanAsync();

    WiFiNetworkReport NetworkReport { get; }

    event TypedEventHandler<WiFiAdapter, object> AvailableNetworksChanged;

    [Overload("ConnectAsync")]
    [RemoteAsync]
    IAsyncOperation<WiFiConnectionResult> ConnectAsync(
      WiFiAvailableNetwork availableNetwork,
      WiFiReconnectionKind reconnectionKind);

    [Overload("ConnectWithPasswordCredentialAsync")]
    IAsyncOperation<WiFiConnectionResult> ConnectAsync(
      WiFiAvailableNetwork availableNetwork,
      WiFiReconnectionKind reconnectionKind,
      PasswordCredential passwordCredential);

    [Overload("ConnectWithPasswordCredentialAndSsidAsync")]
    IAsyncOperation<WiFiConnectionResult> ConnectAsync(
      WiFiAvailableNetwork availableNetwork,
      WiFiReconnectionKind reconnectionKind,
      PasswordCredential passwordCredential,
      string ssid);

    void Disconnect();
  }
}
