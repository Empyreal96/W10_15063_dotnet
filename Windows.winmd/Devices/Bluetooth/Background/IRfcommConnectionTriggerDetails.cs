// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.IRfcommConnectionTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;

namespace Windows.Devices.Bluetooth.Background
{
  [ExclusiveTo(typeof (RfcommConnectionTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4179784525, 11836, 20220, 171, 89, 252, 92, 249, 111, 151, 227)]
  internal interface IRfcommConnectionTriggerDetails
  {
    StreamSocket Socket { get; }

    bool Incoming { get; }

    BluetoothDevice RemoteDevice { get; }
  }
}
