// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbDescriptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Usb
{
  [ExclusiveTo(typeof (UsbDescriptor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(176812566, 24477, 18548, 137, 4, 218, 154, 211, 245, 82, 143)]
  internal interface IUsbDescriptor
  {
    byte Length { get; }

    byte DescriptorType { get; }

    void ReadDescriptorBuffer(IBuffer buffer);
  }
}
