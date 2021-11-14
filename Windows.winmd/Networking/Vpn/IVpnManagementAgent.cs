// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnManagementAgent
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnManagementAgent))]
  [Guid(423007949, 42436, 19134, 133, 43, 120, 91, 228, 203, 62, 52)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVpnManagementAgent
  {
    [RemoteAsync]
    IAsyncOperation<VpnManagementErrorStatus> AddProfileFromXmlAsync(
      string xml);

    [RemoteAsync]
    IAsyncOperation<VpnManagementErrorStatus> AddProfileFromObjectAsync(
      IVpnProfile profile);

    [RemoteAsync]
    IAsyncOperation<VpnManagementErrorStatus> UpdateProfileFromXmlAsync(
      string xml);

    [RemoteAsync]
    IAsyncOperation<VpnManagementErrorStatus> UpdateProfileFromObjectAsync(
      IVpnProfile profile);

    [RemoteAsync]
    IAsyncOperation<IVectorView<IVpnProfile>> GetProfilesAsync();

    [RemoteAsync]
    IAsyncOperation<VpnManagementErrorStatus> DeleteProfileAsync(
      IVpnProfile profile);

    [RemoteAsync]
    IAsyncOperation<VpnManagementErrorStatus> ConnectProfileAsync(
      IVpnProfile profile);

    [RemoteAsync]
    IAsyncOperation<VpnManagementErrorStatus> ConnectProfileWithPasswordCredentialAsync(
      IVpnProfile profile,
      PasswordCredential passwordCredential);

    [RemoteAsync]
    IAsyncOperation<VpnManagementErrorStatus> DisconnectProfileAsync(
      IVpnProfile profile);
  }
}
