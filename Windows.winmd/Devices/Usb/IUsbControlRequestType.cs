// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbControlRequestType
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [ExclusiveTo(typeof (UsbControlRequestType))]
  [Guid(2392090022, 55101, 18142, 148, 190, 170, 231, 240, 124, 15, 92)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUsbControlRequestType
  {
    UsbTransferDirection Direction { get; set; }

    UsbControlTransferType ControlTransferType { get; set; }

    UsbControlRecipient Recipient { get; set; }

    byte AsByte { get; set; }
  }
}
