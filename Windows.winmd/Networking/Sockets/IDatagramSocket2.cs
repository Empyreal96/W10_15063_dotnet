// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IDatagramSocket2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3627787092, 39581, 16773, 162, 10, 20, 36, 201, 194, 167, 205)]
  [ExclusiveTo(typeof (DatagramSocket))]
  internal interface IDatagramSocket2 : IClosable
  {
    [RemoteAsync]
    [Overload("BindServiceNameAndAdapterAsync")]
    IAsyncAction BindServiceNameAsync(string localServiceName, NetworkAdapter adapter);
  }
}
