// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbEndpointDescriptorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [Guid(3364925953, 39530, 18782, 168, 44, 41, 91, 158, 112, 129, 6)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UsbEndpointDescriptor))]
  internal interface IUsbEndpointDescriptorStatics
  {
    bool TryParse(UsbDescriptor descriptor, out UsbEndpointDescriptor parsed);

    UsbEndpointDescriptor Parse(UsbDescriptor descriptor);
  }
}
