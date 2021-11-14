// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.IWiFiDirectServiceAdvertiser
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.WiFiDirect.Services
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WiFiDirectServiceAdvertiser))]
  [Guid(2762612449, 40335, 20303, 147, 238, 125, 222, 162, 227, 127, 70)]
  internal interface IWiFiDirectServiceAdvertiser
  {
    string ServiceName { get; }

    IVector<string> ServiceNamePrefixes { get; }

    IBuffer ServiceInfo { get; set; }

    bool AutoAcceptSession { get; set; }

    bool PreferGroupOwnerMode { get; set; }

    IVector<WiFiDirectServiceConfigurationMethod> PreferredConfigurationMethods { get; }

    WiFiDirectServiceStatus ServiceStatus { get; set; }

    uint CustomServiceStatusCode { get; set; }

    IBuffer DeferredSessionInfo { get; set; }

    WiFiDirectServiceAdvertisementStatus AdvertisementStatus { get; }

    WiFiDirectServiceError ServiceError { get; }

    event TypedEventHandler<WiFiDirectServiceAdvertiser, WiFiDirectServiceSessionRequestedEventArgs> SessionRequested;

    event TypedEventHandler<WiFiDirectServiceAdvertiser, WiFiDirectServiceAutoAcceptSessionConnectedEventArgs> AutoAcceptSessionConnected;

    event TypedEventHandler<WiFiDirectServiceAdvertiser, object> AdvertisementStatusChanged;

    [RemoteAsync]
    [Overload("ConnectAsync")]
    IAsyncOperation<WiFiDirectServiceSession> ConnectAsync(
      DeviceInformation deviceInfo);

    [Overload("ConnectAsyncWithPin")]
    [RemoteAsync]
    IAsyncOperation<WiFiDirectServiceSession> ConnectAsync(
      DeviceInformation deviceInfo,
      string pin);

    void Start();

    void Stop();
  }
}
