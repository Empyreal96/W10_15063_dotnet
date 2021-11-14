// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnChannel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Vpn
{
  [Static(typeof (IVpnChannelStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.MTA)]
  public sealed class VpnChannel : IVpnChannel, IVpnChannel2
  {
    [MethodImpl]
    public extern void AssociateTransport(
      object mainOuterTunnelTransport,
      object optionalOuterTunnelTransport);

    [Overload("Start")]
    [MethodImpl]
    public extern void Start(
      IVectorView<HostName> assignedClientIPv4list,
      IVectorView<HostName> assignedClientIPv6list,
      VpnInterfaceId vpnInterfaceId,
      VpnRouteAssignment routeScope,
      VpnNamespaceAssignment namespaceScope,
      uint mtuSize,
      uint maxFrameSize,
      bool optimizeForLowCostNetwork,
      object mainOuterTunnelTransport,
      object optionalOuterTunnelTransport);

    [MethodImpl]
    public extern void Stop();

    [MethodImpl]
    public extern VpnPickedCredential RequestCredentials(
      VpnCredentialType credType,
      bool isRetry,
      bool isSingleSignOnCredential,
      Certificate certificate);

    [MethodImpl]
    public extern void RequestVpnPacketBuffer(
      VpnDataPathType type,
      out VpnPacketBuffer vpnPacketBuffer);

    [MethodImpl]
    public extern void LogDiagnosticMessage(string message);

    public extern uint Id { [MethodImpl] get; }

    public extern VpnChannelConfiguration Configuration { [MethodImpl] get; }

    public extern event TypedEventHandler<VpnChannel, VpnChannelActivityEventArgs> ActivityChange;

    public extern object PlugInContext { [MethodImpl] set; [MethodImpl] get; }

    public extern VpnSystemHealth SystemHealth { [MethodImpl] get; }

    [MethodImpl]
    public extern void RequestCustomPrompt(IVectorView<IVpnCustomPrompt> customPrompt);

    [MethodImpl]
    public extern void SetErrorMessage(string message);

    [MethodImpl]
    public extern void SetAllowedSslTlsVersions(object tunnelTransport, bool useTls12);

    [MethodImpl]
    public extern void StartWithMainTransport(
      IVectorView<HostName> assignedClientIPv4list,
      IVectorView<HostName> assignedClientIPv6list,
      VpnInterfaceId vpnInterfaceId,
      VpnRouteAssignment assignedRoutes,
      VpnDomainNameAssignment assignedDomainName,
      uint mtuSize,
      uint maxFrameSize,
      bool Reserved,
      object mainOuterTunnelTransport);

    [MethodImpl]
    public extern void StartExistingTransports(
      IVectorView<HostName> assignedClientIPv4list,
      IVectorView<HostName> assignedClientIPv6list,
      VpnInterfaceId vpnInterfaceId,
      VpnRouteAssignment assignedRoutes,
      VpnDomainNameAssignment assignedDomainName,
      uint mtuSize,
      uint maxFrameSize,
      bool Reserved);

    public extern event TypedEventHandler<VpnChannel, VpnChannelActivityStateChangedArgs> ActivityStateChange;

    [MethodImpl]
    public extern VpnPacketBuffer GetVpnSendPacketBuffer();

    [MethodImpl]
    public extern VpnPacketBuffer GetVpnReceivePacketBuffer();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RequestCustomPromptAsync(
      IVectorView<IVpnCustomPromptElement> customPromptElement);

    [Overload("RequestCredentialsWithCertificateAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VpnCredential> RequestCredentialsAsync(
      VpnCredentialType credType,
      uint credOptions,
      Certificate certificate);

    [RemoteAsync]
    [Overload("RequestCredentialsWithOptionsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<VpnCredential> RequestCredentialsAsync(
      VpnCredentialType credType,
      uint credOptions);

    [RemoteAsync]
    [Overload("RequestCredentialsSimpleAsync")]
    [MethodImpl]
    public extern IAsyncOperation<VpnCredential> RequestCredentialsAsync(
      VpnCredentialType credType);

    [MethodImpl]
    public extern void TerminateConnection(string message);

    [MethodImpl]
    public extern void StartWithTrafficFilter(
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

    [MethodImpl]
    public static extern void ProcessEventAsync(object thirdPartyPlugIn, object @event);
  }
}
