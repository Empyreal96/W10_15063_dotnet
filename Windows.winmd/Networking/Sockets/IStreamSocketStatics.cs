// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Guid(2753608778, 28206, 19189, 181, 86, 53, 90, 224, 205, 79, 41)]
  [ExclusiveTo(typeof (StreamSocket))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IStreamSocketStatics
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
