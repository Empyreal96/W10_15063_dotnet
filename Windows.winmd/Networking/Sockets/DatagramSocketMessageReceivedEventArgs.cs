// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.DatagramSocketMessageReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  [DualApiPartition(version = 100794368)]
  [GCPressure(amount = GCPressureAmount.Medium)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DatagramSocketMessageReceivedEventArgs : 
    IDatagramSocketMessageReceivedEventArgs
  {
    public extern HostName RemoteAddress { [MethodImpl] get; }

    public extern string RemotePort { [MethodImpl] get; }

    public extern HostName LocalAddress { [MethodImpl] get; }

    [MethodImpl]
    public extern DataReader GetDataReader();

    [MethodImpl]
    public extern IInputStream GetDataStream();
  }
}
