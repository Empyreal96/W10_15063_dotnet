// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.IHidDeviceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Devices.HumanInterfaceDevice
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HidDevice))]
  [Guid(2656666084, 38998, 16780, 159, 115, 119, 222, 12, 216, 87, 84)]
  internal interface IHidDeviceStatics
  {
    [Overload("GetDeviceSelector")]
    string GetDeviceSelector(ushort usagePage, ushort usageId);

    [Overload("GetDeviceSelectorVidPid")]
    string GetDeviceSelector(ushort usagePage, ushort usageId, ushort vendorId, ushort productId);

    [RemoteAsync]
    IAsyncOperation<HidDevice> FromIdAsync(
      string deviceId,
      FileAccessMode accessMode);
  }
}
