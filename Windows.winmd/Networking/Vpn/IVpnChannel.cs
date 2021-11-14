// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnChannel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1254591751, 53672, 17155, 160, 145, 200, 210, 224, 145, 91, 195)]
  [ExclusiveTo(typeof (VpnChannel))]
  internal interface IVpnChannel
  {
    void AssociateTransport(object mainOuterTunnelTransport, object optionalOuterTunnelTransport);

    [Overload("Start")]
    void Start(
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

    void Stop();

    VpnPickedCredential RequestCredentials(
      VpnCredentialType credType,
      bool isRetry,
      bool isSingleSignOnCredential,
      Certificate certificate);

    void RequestVpnPacketBuffer(VpnDataPathType type, out VpnPacketBuffer vpnPacketBuffer);

    void LogDiagnosticMessage(string message);

    uint Id { get; }

    VpnChannelConfiguration Configuration { get; }

    event TypedEventHandler<VpnChannel, VpnChannelActivityEventArgs> ActivityChange;

    object PlugInContext { set; get; }

    VpnSystemHealth SystemHealth { get; }

    void RequestCustomPrompt(IVectorView<IVpnCustomPrompt> customPrompt);

    void SetErrorMessage(string message);

    void SetAllowedSslTlsVersions(object tunnelTransport, bool useTls12);
  }
}
