// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbConfigurationDescriptorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [Guid(1112337811, 59200, 16545, 146, 189, 218, 18, 14, 160, 73, 20)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UsbConfigurationDescriptor))]
  internal interface IUsbConfigurationDescriptorStatics
  {
    bool TryParse(UsbDescriptor descriptor, out UsbConfigurationDescriptor parsed);

    UsbConfigurationDescriptor Parse(UsbDescriptor descriptor);
  }
}
