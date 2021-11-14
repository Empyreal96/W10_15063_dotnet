// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.INetworkInformationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [Guid(1349843025, 38157, 16741, 156, 21, 54, 86, 25, 72, 30, 234)]
  [ExclusiveTo(typeof (NetworkInformation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface INetworkInformationStatics
  {
    IVectorView<ConnectionProfile> GetConnectionProfiles();

    ConnectionProfile GetInternetConnectionProfile();

    IVectorView<LanIdentifier> GetLanIdentifiers();

    IVectorView<HostName> GetHostNames();

    [RemoteAsync]
    IAsyncOperation<ProxyConfiguration> GetProxyConfigurationAsync(
      Uri uri);

    IVectorView<EndpointPair> GetSortedEndpointPairs(
      IIterable<EndpointPair> destinationList,
      HostNameSortOptions sortOptions);

    event NetworkStatusChangedEventHandler NetworkStatusChanged;
  }
}
