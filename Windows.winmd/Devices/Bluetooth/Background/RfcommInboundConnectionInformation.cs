// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.RfcommInboundConnectionInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth.Rfcomm;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class RfcommInboundConnectionInformation : IRfcommInboundConnectionInformation
  {
    public extern IBuffer SdpRecord { [MethodImpl] get; [MethodImpl] set; }

    public extern RfcommServiceId LocalServiceId { [MethodImpl] get; [MethodImpl] set; }

    public extern BluetoothServiceCapabilities ServiceCapabilities { [MethodImpl] get; [MethodImpl] set; }
  }
}
