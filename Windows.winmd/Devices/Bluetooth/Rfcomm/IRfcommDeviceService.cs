// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.IRfcommDeviceService
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;
using Windows.Networking.Sockets;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RfcommDeviceService))]
  [Guid(2927755039, 50593, 19520, 140, 40, 243, 239, 214, 144, 98, 243)]
  internal interface IRfcommDeviceService
  {
    HostName ConnectionHostName { get; }

    string ConnectionServiceName { get; }

    RfcommServiceId ServiceId { get; }

    SocketProtectionLevel ProtectionLevel { get; }

    SocketProtectionLevel MaxProtectionLevel { get; }

    [RemoteAsync]
    [Overload("GetSdpRawAttributesAsync")]
    IAsyncOperation<IMapView<uint, IBuffer>> GetSdpRawAttributesAsync();

    [Overload("GetSdpRawAttributesWithCacheModeAsync")]
    [RemoteAsync]
    IAsyncOperation<IMapView<uint, IBuffer>> GetSdpRawAttributesAsync(
      BluetoothCacheMode cacheMode);
  }
}
