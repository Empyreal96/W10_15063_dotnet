// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.SystemAccess.IDeviceAccountConfiguration2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.ApplicationModel.UserDataAccounts.SystemAccess
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4071810470, 29325, 19018, 137, 69, 43, 248, 88, 1, 54, 222)]
  [ExclusiveTo(typeof (DeviceAccountConfiguration))]
  internal interface IDeviceAccountConfiguration2
  {
    PasswordCredential IncomingServerCredential { get; set; }

    PasswordCredential OutgoingServerCredential { get; set; }

    string OAuthRefreshToken { get; set; }

    bool IsExternallyManaged { get; set; }

    DeviceAccountIconId AccountIconId { get; set; }

    DeviceAccountAuthenticationType AuthenticationType { get; set; }

    bool IsSsoAuthenticationSupported { get; }

    string SsoAccountId { get; set; }

    bool AlwaysDownloadFullMessage { get; set; }

    bool DoesPolicyAllowMailSync { get; }

    DeviceAccountSyncScheduleKind SyncScheduleKind { get; set; }

    DeviceAccountMailAgeFilter MailAgeFilter { get; set; }

    bool IsClientAuthenticationCertificateRequired { get; set; }

    bool AutoSelectAuthenticationCertificate { get; set; }

    string AuthenticationCertificateId { get; set; }

    DeviceAccountSyncScheduleKind CardDavSyncScheduleKind { get; set; }

    DeviceAccountSyncScheduleKind CalDavSyncScheduleKind { get; set; }

    Uri CardDavServerUrl { get; set; }

    bool CardDavRequiresSsl { get; set; }

    Uri CalDavServerUrl { get; set; }

    bool CalDavRequiresSsl { get; set; }

    bool WasModifiedByUser { get; set; }

    bool WasIncomingServerCertificateHashConfirmed { get; set; }

    string IncomingServerCertificateHash { get; set; }

    bool IsOutgoingServerAuthenticationRequired { get; set; }

    bool IsOutgoingServerAuthenticationEnabled { get; set; }

    bool WasOutgoingServerCertificateHashConfirmed { get; set; }

    string OutgoingServerCertificateHash { get; set; }

    bool IsSyncScheduleManagedBySystem { get; set; }
  }
}
