// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.TriggeredConnectionStateChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;

namespace Windows.Networking.Proximity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class TriggeredConnectionStateChangedEventArgs : 
    ITriggeredConnectionStateChangedEventArgs
  {
    public extern TriggeredConnectState State { [MethodImpl] get; }

    public extern uint Id { [MethodImpl] get; }

    public extern StreamSocket Socket { [MethodImpl] get; }
  }
}
