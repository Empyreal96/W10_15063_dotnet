// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IDatagramSocketStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DatagramSocket))]
  [Guid(3922078446, 5268, 18977, 187, 126, 133, 137, 252, 117, 29, 157)]
  internal interface IDatagramSocketStatics
  {
    [RemoteAsync]
    [Overload("GetEndpointPairsAsync")]
    IAsyncOperation<IVectorView<EndpointPair>> GetEndpointPairsAsync(
      HostName remoteHostName,
      string remoteServiceName);

    [Overload("GetEndpointPairsWithSortOptionsAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<EndpointPair>> GetEndpointPairsAsync(
      HostName remoteHostName,
      string remoteServiceName,
      HostNameSortOptions sortOptions);
  }
}
