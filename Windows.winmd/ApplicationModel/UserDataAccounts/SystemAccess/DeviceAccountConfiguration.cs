// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.SystemAccess.DeviceAccountConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.ApplicationModel.UserDataAccounts.SystemAccess
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DeviceAccountConfiguration : 
    IDeviceAccountConfiguration,
    IDeviceAccountConfiguration2
  {
    [MethodImpl]
    public extern DeviceAccountConfiguration();

    public extern string AccountName { [MethodImpl] get; [MethodImpl] set; }

    public extern string DeviceAccountTypeId { [MethodImpl] get; [MethodImpl] set; }

    public extern DeviceAccountServerType ServerType { [MethodImpl] get; [MethodImpl] set; }

    public extern string EmailAddress { [MethodImpl] get; [MethodImpl] set; }

    public extern string Domain { [MethodImpl] get; [MethodImpl] set; }

    public extern bool EmailSyncEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool ContactsSyncEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CalendarSyncEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern string IncomingServerAddress { [MethodImpl] get; [MethodImpl] set; }

    public extern int IncomingServerPort { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IncomingServerRequiresSsl { [MethodImpl] get; [MethodImpl] set; }

    public extern string IncomingServerUsername { [MethodImpl] get; [MethodImpl] set; }

    public extern string OutgoingServerAddress { [MethodImpl] get; [MethodImpl] set; }

    public extern int OutgoingServerPort { [MethodImpl] get; [MethodImpl] set; }

    public extern bool OutgoingServerRequiresSsl { [MethodImpl] get; [MethodImpl] set; }

    public extern string OutgoingServerUsername { [MethodImpl] get; [MethodImpl] set; }

    public extern PasswordCredential IncomingServerCredential { [MethodImpl] get; [MethodImpl] set; }

    public extern PasswordCredential OutgoingServerCredential { [MethodImpl] get; [MethodImpl] set; }

    public extern string OAuthRefreshToken { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsExternallyManaged { [MethodImpl] get; [MethodImpl] set; }

    public extern DeviceAccountIconId AccountIconId { [MethodImpl] get; [MethodImpl] set; }

    public extern DeviceAccountAuthenticationType AuthenticationType { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsSsoAuthenticationSupported { [MethodImpl] get; }

    public extern string SsoAccountId { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AlwaysDownloadFullMessage { [MethodImpl] get; [MethodImpl] set; }

    public extern bool DoesPolicyAllowMailSync { [MethodImpl] get; }

    public extern DeviceAccountSyncScheduleKind SyncScheduleKind { [MethodImpl] get; [MethodImpl] set; }

    public extern DeviceAccountMailAgeFilter MailAgeFilter { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsClientAuthenticationCertificateRequired { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AutoSelectAuthenticationCertificate { [MethodImpl] get; [MethodImpl] set; }

    public extern string AuthenticationCertificateId { [MethodImpl] get; [MethodImpl] set; }

    public extern DeviceAccountSyncScheduleKind CardDavSyncScheduleKind { [MethodImpl] get; [MethodImpl] set; }

    public extern DeviceAccountSyncScheduleKind CalDavSyncScheduleKind { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri CardDavServerUrl { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CardDavRequiresSsl { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri CalDavServerUrl { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CalDavRequiresSsl { [MethodImpl] get; [MethodImpl] set; }

    public extern bool WasModifiedByUser { [MethodImpl] get; [MethodImpl] set; }

    public extern bool WasIncomingServerCertificateHashConfirmed { [MethodImpl] get; [MethodImpl] set; }

    public extern string IncomingServerCertificateHash { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsOutgoingServerAuthenticationRequired { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsOutgoingServerAuthenticationEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool WasOutgoingServerCertificateHashConfirmed { [MethodImpl] get; [MethodImpl] set; }

    public extern string OutgoingServerCertificateHash { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsSyncScheduleManagedBySystem { [MethodImpl] get; [MethodImpl] set; }
  }
}
