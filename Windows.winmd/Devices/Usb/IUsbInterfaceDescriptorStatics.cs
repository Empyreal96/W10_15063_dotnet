// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbInterfaceDescriptorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [Guid(3813318645, 30678, 18614, 176, 190, 22, 198, 66, 35, 22, 254)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UsbInterfaceDescriptor))]
  internal interface IUsbInterfaceDescriptorStatics
  {
    bool TryParse(UsbDescriptor descriptor, out UsbInterfaceDescriptor parsed);

    UsbInterfaceDescriptor Parse(UsbDescriptor descriptor);
  }
}
