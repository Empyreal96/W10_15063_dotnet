// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [Guid(1746367529, 13993, 18135, 184, 115, 252, 104, 146, 81, 236, 48)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UsbConfiguration))]
  internal interface IUsbConfiguration
  {
    IVectorView<UsbInterface> UsbInterfaces { get; }

    UsbConfigurationDescriptor ConfigurationDescriptor { get; }

    IVectorView<UsbDescriptor> Descriptors { get; }
  }
}
