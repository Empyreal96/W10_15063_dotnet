// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnChannel2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Vpn
{
  [Guid(576049509, 39227, 17961, 173, 96, 241, 195, 243, 83, 127, 80)]
  [ExclusiveTo(typeof (VpnChannel))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVpnChannel2
  {
    void StartWithMainTransport(
      IVectorView<HostName> assignedClientIPv4list,
      IVectorView<HostName> assignedClientIPv6list,
      VpnInterfaceId vpnInterfaceId,
      VpnRouteAssignment assignedRoutes,
      VpnDomainNameAssignment assignedDomainName,
      uint mtuSize,
      uint maxFrameSize,
      bool Reserved,
      object mainOuterTunnelTransport);

    void StartExistingTransports(
      IVectorView<HostName> assignedClientIPv4list,
      IVectorView<HostName> assignedClientIPv6list,
      VpnInterfaceId vpnInterfaceId,
      VpnRouteAssignment assignedRoutes,
      VpnDomainNameAssignment assignedDomainName,
      uint mtuSize,
      uint maxFrameSize,
      bool Reserved);

    event TypedEventHandler<VpnChannel, VpnChannelActivityStateChangedArgs> ActivityStateChange;

    VpnPacketBuffer GetVpnSendPacketBuffer();

    VpnPacketBuffer GetVpnReceivePacketBuffer();

    [RemoteAsync]
    IAsyncAction RequestCustomPromptAsync(
      IVectorView<IVpnCustomPromptElement> customPromptElement);

    [Overload("RequestCredentialsWithCertificateAsync")]
    [RemoteAsync]
    IAsyncOperation<VpnCredential> RequestCredentialsAsync(
      VpnCredentialType credType,
      uint credOptions,
      Certificate certificate);

    [Overload("RequestCredentialsWithOptionsAsync")]
    [RemoteAsync]
    IAsyncOperation<VpnCredential> RequestCredentialsAsync(
      VpnCredentialType credType,
      uint credOptions);

    [RemoteAsync]
    [Overload("RequestCredentialsSimpleAsync")]
    IAsyncOperation<VpnCredential> RequestCredentialsAsync(
      VpnCredentialType credType);

    void TerminateConnection(string message);

    void StartWithTrafficFilter(
      IVectorView<HostName> assignedClientIpv4List,
      IVectorView<HostName> assignedClientIpv6List,
      VpnInterfaceId vpnInterfaceId,
      VpnRouteAssignment assignedRoutes,
      VpnDomainNameAssignment assignedNamespace,
      uint mtuSize,
      uint maxFrameSize,
      bool reserved,
      object mainOuterTunnelTransport,
      object optionalOuterTunnelTransport,
      VpnTrafficFilterAssignment assignedTrafficFilters);
  }
}
