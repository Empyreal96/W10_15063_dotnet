// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnManagementAgent
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.MTA)]
  public sealed class VpnManagementAgent : IVpnManagementAgent
  {
    [MethodImpl]
    public extern VpnManagementAgent();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VpnManagementErrorStatus> AddProfileFromXmlAsync(
      string xml);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VpnManagementErrorStatus> AddProfileFromObjectAsync(
      IVpnProfile profile);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VpnManagementErrorStatus> UpdateProfileFromXmlAsync(
      string xml);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VpnManagementErrorStatus> UpdateProfileFromObjectAsync(
      IVpnProfile profile);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IVpnProfile>> GetProfilesAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VpnManagementErrorStatus> DeleteProfileAsync(
      IVpnProfile profile);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VpnManagementErrorStatus> ConnectProfileAsync(
      IVpnProfile profile);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VpnManagementErrorStatus> ConnectProfileWithPasswordCredentialAsync(
      IVpnProfile profile,
      PasswordCredential passwordCredential);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VpnManagementErrorStatus> DisconnectProfileAsync(
      IVpnProfile profile);
  }
}
