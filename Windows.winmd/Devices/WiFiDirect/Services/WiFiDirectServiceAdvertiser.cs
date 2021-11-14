// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.WiFiDirectServiceAdvertiser
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.WiFiDirect.Services
{
  [Activatable(typeof (IWiFiDirectServiceAdvertiserFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class WiFiDirectServiceAdvertiser : IWiFiDirectServiceAdvertiser
  {
    [MethodImpl]
    public extern WiFiDirectServiceAdvertiser(string serviceName);

    public extern string ServiceName { [MethodImpl] get; }

    public extern IVector<string> ServiceNamePrefixes { [MethodImpl] get; }

    public extern IBuffer ServiceInfo { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AutoAcceptSession { [MethodImpl] get; [MethodImpl] set; }

    public extern bool PreferGroupOwnerMode { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<WiFiDirectServiceConfigurationMethod> PreferredConfigurationMethods { [MethodImpl] get; }

    public extern WiFiDirectServiceStatus ServiceStatus { [MethodImpl] get; [MethodImpl] set; }

    public extern uint CustomServiceStatusCode { [MethodImpl] get; [MethodImpl] set; }

    public extern IBuffer DeferredSessionInfo { [MethodImpl] get; [MethodImpl] set; }

    public extern WiFiDirectServiceAdvertisementStatus AdvertisementStatus { [MethodImpl] get; }

    public extern WiFiDirectServiceError ServiceError { [MethodImpl] get; }

    public extern event TypedEventHandler<WiFiDirectServiceAdvertiser, WiFiDirectServiceSessionRequestedEventArgs> SessionRequested;

    public extern event TypedEventHandler<WiFiDirectServiceAdvertiser, WiFiDirectServiceAutoAcceptSessionConnectedEventArgs> AutoAcceptSessionConnected;

    public extern event TypedEventHandler<WiFiDirectServiceAdvertiser, object> AdvertisementStatusChanged;

    [RemoteAsync]
    [Overload("ConnectAsync")]
    [MethodImpl]
    public extern IAsyncOperation<WiFiDirectServiceSession> ConnectAsync(
      DeviceInformation deviceInfo);

    [Overload("ConnectAsyncWithPin")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<WiFiDirectServiceSession> ConnectAsync(
      DeviceInformation deviceInfo,
      string pin);

    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Stop();
  }
}
