// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.IWiFiDirectService
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.WiFiDirect.Services
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1353366456, 24433, 17900, 132, 241, 161, 228, 252, 120, 121, 163)]
  [ExclusiveTo(typeof (WiFiDirectService))]
  internal interface IWiFiDirectService
  {
    IBuffer RemoteServiceInfo { get; }

    IVectorView<WiFiDirectServiceConfigurationMethod> SupportedConfigurationMethods { get; }

    bool PreferGroupOwnerMode { get; set; }

    IBuffer SessionInfo { get; set; }

    WiFiDirectServiceError ServiceError { get; }

    event TypedEventHandler<WiFiDirectService, WiFiDirectServiceSessionDeferredEventArgs> SessionDeferred;

    [RemoteAsync]
    IAsyncOperation<WiFiDirectServiceProvisioningInfo> GetProvisioningInfoAsync(
      WiFiDirectServiceConfigurationMethod selectedConfigurationMethod);

    [RemoteAsync]
    [Overload("ConnectAsync")]
    IAsyncOperation<WiFiDirectServiceSession> ConnectAsync();

    [RemoteAsync]
    [Overload("ConnectAsyncWithPin")]
    IAsyncOperation<WiFiDirectServiceSession> ConnectAsync(
      string pin);
  }
}
