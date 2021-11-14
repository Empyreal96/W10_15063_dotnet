// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnManagementErrorStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VpnManagementErrorStatus
  {
    Ok,
    Other,
    InvalidXmlSyntax,
    ProfileNameTooLong,
    ProfileInvalidAppId,
    AccessDenied,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] CannotFindProfile,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] AlreadyDisconnecting,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] AlreadyConnected,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] GeneralAuthenticationFailure,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] EapFailure,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] SmartCardFailure,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] CertificateFailure,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] ServerConfiguration,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] NoConnection,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] ServerConnection,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] UserNamePassword,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] DnsNotResolvable,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] InvalidIP,
  }
}
