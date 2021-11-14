// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Gpio.Provider.IGpioProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Gpio.Provider
{
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  [Guid(1156065031, 2250, 17226, 175, 224, 214, 21, 128, 68, 111, 126)]
  public interface IGpioProvider
  {
    IVectorView<IGpioControllerProvider> GetControllers();
  }
}
