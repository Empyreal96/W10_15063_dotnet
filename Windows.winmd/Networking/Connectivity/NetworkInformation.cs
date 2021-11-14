// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.NetworkInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [Static(typeof (INetworkInformationStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (INetworkInformationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class NetworkInformation
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<ConnectionProfile>> FindConnectionProfilesAsync(
      ConnectionProfileFilter pProfileFilter);

    [MethodImpl]
    public static extern IVectorView<ConnectionProfile> GetConnectionProfiles();

    [MethodImpl]
    public static extern ConnectionProfile GetInternetConnectionProfile();

    [MethodImpl]
    public static extern IVectorView<LanIdentifier> GetLanIdentifiers();

    [MethodImpl]
    public static extern IVectorView<HostName> GetHostNames();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ProxyConfiguration> GetProxyConfigurationAsync(
      Uri uri);

    [MethodImpl]
    public static extern IVectorView<EndpointPair> GetSortedEndpointPairs(
      IIterable<EndpointPair> destinationList,
      HostNameSortOptions sortOptions);

    public static extern event NetworkStatusChangedEventHandler NetworkStatusChanged;
  }
}
