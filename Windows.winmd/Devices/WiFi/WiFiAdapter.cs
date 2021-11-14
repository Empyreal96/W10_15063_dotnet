// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFi.WiFiAdapter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;
using Windows.Security.Credentials;

namespace Windows.Devices.WiFi
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IWiFiAdapterStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class WiFiAdapter : IWiFiAdapter
  {
    public extern NetworkAdapter NetworkAdapter { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ScanAsync();

    public extern WiFiNetworkReport NetworkReport { [MethodImpl] get; }

    public extern event TypedEventHandler<WiFiAdapter, object> AvailableNetworksChanged;

    [Overload("ConnectAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<WiFiConnectionResult> ConnectAsync(
      WiFiAvailableNetwork availableNetwork,
      WiFiReconnectionKind reconnectionKind);

    [Overload("ConnectWithPasswordCredentialAsync")]
    [MethodImpl]
    public extern IAsyncOperation<WiFiConnectionResult> ConnectAsync(
      WiFiAvailableNetwork availableNetwork,
      WiFiReconnectionKind reconnectionKind,
      PasswordCredential passwordCredential);

    [Overload("ConnectWithPasswordCredentialAndSsidAsync")]
    [MethodImpl]
    public extern IAsyncOperation<WiFiConnectionResult> ConnectAsync(
      WiFiAvailableNetwork availableNetwork,
      WiFiReconnectionKind reconnectionKind,
      PasswordCredential passwordCredential,
      string ssid);

    [MethodImpl]
    public extern void Disconnect();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<WiFiAdapter>> FindAllAdaptersAsync();

    [MethodImpl]
    public static extern string GetDeviceSelector();

    [Overload("FromIdAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WiFiAdapter> FromIdAsync(
      string deviceId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WiFiAccessStatus> RequestAccessAsync();
  }
}
