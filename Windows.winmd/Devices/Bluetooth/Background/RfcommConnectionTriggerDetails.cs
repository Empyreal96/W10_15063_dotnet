// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.RfcommConnectionTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;

namespace Windows.Devices.Bluetooth.Background
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class RfcommConnectionTriggerDetails : IRfcommConnectionTriggerDetails
  {
    public extern StreamSocket Socket { [MethodImpl] get; }

    public extern bool Incoming { [MethodImpl] get; }

    public extern BluetoothDevice RemoteDevice { [MethodImpl] get; }
  }
}
