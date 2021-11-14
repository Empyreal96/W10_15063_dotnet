// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.WiFiDirectService
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.WiFiDirect.Services
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IWiFiDirectServiceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class WiFiDirectService : IWiFiDirectService
  {
    public extern IBuffer RemoteServiceInfo { [MethodImpl] get; }

    public extern IVectorView<WiFiDirectServiceConfigurationMethod> SupportedConfigurationMethods { [MethodImpl] get; }

    public extern bool PreferGroupOwnerMode { [MethodImpl] get; [MethodImpl] set; }

    public extern IBuffer SessionInfo { [MethodImpl] get; [MethodImpl] set; }

    public extern WiFiDirectServiceError ServiceError { [MethodImpl] get; }

    public extern event TypedEventHandler<WiFiDirectService, WiFiDirectServiceSessionDeferredEventArgs> SessionDeferred;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<WiFiDirectServiceProvisioningInfo> GetProvisioningInfoAsync(
      WiFiDirectServiceConfigurationMethod selectedConfigurationMethod);

    [RemoteAsync]
    [Overload("ConnectAsync")]
    [MethodImpl]
    public extern IAsyncOperation<WiFiDirectServiceSession> ConnectAsync();

    [RemoteAsync]
    [Overload("ConnectAsyncWithPin")]
    [MethodImpl]
    public extern IAsyncOperation<WiFiDirectServiceSession> ConnectAsync(
      string pin);

    [Overload("GetSelector")]
    [MethodImpl]
    public static extern string GetSelector(string serviceName);

    [Overload("GetSelectorWithFilter")]
    [MethodImpl]
    public static extern string GetSelector(string serviceName, IBuffer serviceInfoFilter);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WiFiDirectService> FromIdAsync(
      string deviceId);
  }
}
