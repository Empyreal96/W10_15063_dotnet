// Decompiled with JetBrains decompiler
// Type: Windows.Devices.I2c.II2cDeviceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.I2c
{
  [Guid(2443394019, 29492, 17682, 150, 188, 251, 174, 148, 89, 245, 246)]
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  public interface II2cDeviceStatics
  {
    [Overload("GetDeviceSelector")]
    string GetDeviceSelector();

    [Overload("GetDeviceSelectorFromFriendlyName")]
    string GetDeviceSelector(string friendlyName);

    [RemoteAsync]
    IAsyncOperation<I2cDevice> FromIdAsync(
      string deviceId,
      I2cConnectionSettings settings);
  }
}
