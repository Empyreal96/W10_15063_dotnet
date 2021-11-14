// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Spi.ISpiDeviceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Spi
{
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  [Guid(2725832025, 22304, 19775, 189, 147, 86, 245, 255, 90, 88, 121)]
  public interface ISpiDeviceStatics
  {
    [Overload("GetDeviceSelector")]
    string GetDeviceSelector();

    [Overload("GetDeviceSelectorFromFriendlyName")]
    string GetDeviceSelector(string friendlyName);

    SpiBusInfo GetBusInfo(string busId);

    [RemoteAsync]
    IAsyncOperation<SpiDevice> FromIdAsync(
      string busId,
      SpiConnectionSettings settings);
  }
}
