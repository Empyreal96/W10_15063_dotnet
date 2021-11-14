// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.WiFiDirectDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;

namespace Windows.Devices.WiFiDirect
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IWiFiDirectDeviceStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IWiFiDirectDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  public sealed class WiFiDirectDevice : IWiFiDirectDevice, IClosable
  {
    public extern WiFiDirectConnectionStatus ConnectionStatus { [MethodImpl] get; }

    public extern string DeviceId { [MethodImpl] get; }

    public extern event TypedEventHandler<WiFiDirectDevice, object> ConnectionStatusChanged;

    [MethodImpl]
    public extern IVectorView<EndpointPair> GetConnectionEndpointPairs();

    [MethodImpl]
    public extern void Close();

    [Overload("GetDeviceSelector")]
    [MethodImpl]
    public static extern string GetDeviceSelector(WiFiDirectDeviceSelectorType type);

    [Overload("FromIdAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WiFiDirectDevice> FromIdAsync(
      string deviceId,
      WiFiDirectConnectionParameters connectionParameters);

    [Overload("GetDeviceSelector")]
    [MethodImpl]
    public static extern string GetDeviceSelector();

    [RemoteAsync]
    [Overload("FromIdAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WiFiDirectDevice> FromIdAsync(
      string deviceId);
  }
}
