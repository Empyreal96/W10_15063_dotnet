// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbConfigurationDescriptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [ExclusiveTo(typeof (UsbConfigurationDescriptor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4061621650, 46146, 16506, 130, 7, 125, 100, 108, 3, 133, 243)]
  internal interface IUsbConfigurationDescriptor
  {
    byte ConfigurationValue { get; }

    uint MaxPowerMilliamps { get; }

    bool SelfPowered { get; }

    bool RemoteWakeup { get; }
  }
}
