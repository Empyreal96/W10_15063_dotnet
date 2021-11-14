// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbSetupPacket
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [Guid(273391922, 51087, 19537, 182, 84, 228, 157, 2, 242, 203, 3)]
  [ExclusiveTo(typeof (UsbSetupPacket))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUsbSetupPacket
  {
    UsbControlRequestType RequestType { get; set; }

    byte Request { get; set; }

    uint Value { get; set; }

    uint Index { get; set; }

    uint Length { get; set; }
  }
}
