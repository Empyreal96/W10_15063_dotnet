// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Pwm.IPwmControllerStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Pwm
{
  [Guid(2992117873, 553, 17220, 174, 63, 155, 124, 208, 230, 107, 148)]
  [ExclusiveTo(typeof (PwmController))]
  [ContractVersion(typeof (DevicesLowLevelContract), 196608)]
  internal interface IPwmControllerStatics3
  {
    [Overload("GetDeviceSelector")]
    string GetDeviceSelector();

    [Overload("GetDeviceSelectorFromFriendlyName")]
    string GetDeviceSelector(string friendlyName);

    [RemoteAsync]
    IAsyncOperation<PwmController> FromIdAsync(string deviceId);
  }
}
