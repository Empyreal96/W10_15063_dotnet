// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Gpio.IGpioControllerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.Gpio
{
  [ExclusiveTo(typeof (GpioController))]
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  [Guid(785839150, 31479, 16662, 149, 51, 196, 61, 153, 161, 251, 100)]
  internal interface IGpioControllerStatics
  {
    GpioController GetDefault();
  }
}
