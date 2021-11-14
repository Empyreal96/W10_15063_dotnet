// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.IRfcommDeviceServiceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  [ExclusiveTo(typeof (RfcommDeviceService))]
  [Guid(2762033647, 25197, 16812, 178, 83, 135, 172, 92, 39, 226, 138)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRfcommDeviceServiceStatics
  {
    [RemoteAsync]
    IAsyncOperation<RfcommDeviceService> FromIdAsync(
      string deviceId);

    string GetDeviceSelector(RfcommServiceId serviceId);
  }
}
