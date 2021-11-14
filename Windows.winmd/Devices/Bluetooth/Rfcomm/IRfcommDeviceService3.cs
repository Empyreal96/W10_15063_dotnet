// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.IRfcommDeviceService3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(472034534, 56644, 19747, 134, 109, 143, 52, 134, 238, 100, 144)]
  [ExclusiveTo(typeof (RfcommDeviceService))]
  internal interface IRfcommDeviceService3 : IRfcommDeviceService2, IRfcommDeviceService
  {
    DeviceAccessInformation DeviceAccessInformation { get; }

    [RemoteAsync]
    IAsyncOperation<DeviceAccessStatus> RequestAccessAsync();
  }
}
