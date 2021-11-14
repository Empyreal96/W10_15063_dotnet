// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.IRfcommOutboundConnectionInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Bluetooth.Rfcomm;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Background
{
  [Guid(2962301563, 62516, 19632, 153, 177, 74, 184, 206, 218, 237, 215)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RfcommOutboundConnectionInformation))]
  internal interface IRfcommOutboundConnectionInformation
  {
    RfcommServiceId RemoteServiceId { get; set; }
  }
}
