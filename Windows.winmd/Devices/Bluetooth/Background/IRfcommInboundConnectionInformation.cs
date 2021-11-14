// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.IRfcommInboundConnectionInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Bluetooth.Rfcomm;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Background
{
  [ExclusiveTo(typeof (RfcommInboundConnectionInformation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1832809896, 21545, 16473, 146, 227, 30, 139, 101, 82, 135, 7)]
  internal interface IRfcommInboundConnectionInformation
  {
    IBuffer SdpRecord { get; set; }

    RfcommServiceId LocalServiceId { get; set; }

    BluetoothServiceCapabilities ServiceCapabilities { get; set; }
  }
}
