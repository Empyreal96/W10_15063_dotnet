// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IDatagramSocketMessageReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  [Guid(2653805730, 5906, 19684, 177, 121, 140, 101, 44, 109, 16, 126)]
  [ExclusiveTo(typeof (DatagramSocketMessageReceivedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDatagramSocketMessageReceivedEventArgs
  {
    HostName RemoteAddress { get; }

    string RemotePort { get; }

    HostName LocalAddress { get; }

    DataReader GetDataReader();

    IInputStream GetDataStream();
  }
}
