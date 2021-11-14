// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Sync.AccountProperties
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Sync
{
  [Threading(ThreadingModel.Both)]
  [Version(100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAccountPropertiesStatics), 100859904)]
  public static class AccountProperties
  {
    public static extern string Id { [MethodImpl] get; }

    public static extern string Name { [MethodImpl] get; }

    public static extern string Icon { [MethodImpl] get; }

    public static extern string EmailAddress { [MethodImpl] get; }

    public static extern string LastSyncSuccess { [MethodImpl] get; }

    public static extern string LastSyncAttempt { [MethodImpl] get; }

    public static extern string LastSyncResult { [MethodImpl] get; }

    public static extern string LastUsed { [MethodImpl] get; }

    public static extern string DeleteInProgress { [MethodImpl] get; }

    public static extern string SMIMEAlwaysEncrypt { [MethodImpl] get; }

    public static extern string SMIMEAlwaysSign { [MethodImpl] get; }

    public static extern string RequireEncryptedSMIMEMessages { [MethodImpl] get; }

    public static extern string RequireSignedSMIMEMessages { [MethodImpl] get; }

    public static extern string AllowSMIMEEncryptionAlgorithmNegotiation { [MethodImpl] get; }

    public static extern string AllowSMIMESoftCerts { [MethodImpl] get; }

    public static extern string RequiredEncryptionSMIMEAlgorithm { [MethodImpl] get; }

    public static extern string RequiredSignedSMIMEAlgorithm { [MethodImpl] get; }

    public static extern string AuthenticationType { [MethodImpl] get; }

    public static extern string RefreshToken { [MethodImpl] get; }

    public static extern string TokenExpiration { [MethodImpl] get; }

    public static extern string SSOAccountId { [MethodImpl] get; }

    public static extern string UserDataAccountId { [MethodImpl] get; }

    public static extern string AllowMailTruncation { [MethodImpl] get; }

    public static extern string AllowMailSync { [MethodImpl] get; }

    public static extern string InitialAutdHeartbeat { [MethodImpl] get; }

    public static extern string MinAutdHeartbeat { [MethodImpl] get; }

    public static extern string MaxAutdHeartbeat { [MethodImpl] get; }

    public static extern string AutdHeartbeatIncrement { [MethodImpl] get; }

    public static extern string AccountMigrated { [MethodImpl] get; }

    public static extern string IsExternallyManaged { [MethodImpl] get; }

    public static extern string ActiveSync_Type { [MethodImpl] get; }

    public static extern string ActiveSync_Server { [MethodImpl] get; }

    public static extern string ActiveSync_Domain { [MethodImpl] get; }

    public static extern string ActiveSync_UserName { [MethodImpl] get; }

    public static extern string ActiveSync_Password { [MethodImpl] get; }

    public static extern string ActiveSync_ServerUseSsl { [MethodImpl] get; }

    public static extern string ActiveSync_SyncFrequency { [MethodImpl] get; }

    public static extern string ActiveSync_CalendarAgeFilter { [MethodImpl] get; }

    public static extern string ActiveSync_MaxMailAgeFilter { [MethodImpl] get; }

    public static extern string ActiveSync_MailAgeFilter { [MethodImpl] get; }

    public static extern string ActiveSync_MailBodyType { [MethodImpl] get; }

    public static extern string ActiveSync_MailHTMLTruncation { [MethodImpl] get; }

    public static extern string ActiveSync_MailPlainTextTruncation { [MethodImpl] get; }

    public static extern string ActiveSync_ContactsEnabled { [MethodImpl] get; }

    public static extern string ActiveSync_CalendarEnabled { [MethodImpl] get; }

    public static extern string ActiveSync_MailEnabled { [MethodImpl] get; }

    public static extern string ActiveSync_TasksEnabled { [MethodImpl] get; }

    public static extern string ActiveSync_PhotoEnabled { [MethodImpl] get; }

    public static extern string ActiveSync_FeedsEnabled { [MethodImpl] get; }

    public static extern string ActiveSync_HasSynced { [MethodImpl] get; }

    public static extern string ActiveSync_IsDefaultAccount { [MethodImpl] get; }

    public static extern string ActiveSync_ConversationSyncEnabled { [MethodImpl] get; }

    public static extern string ActiveSync_DomainUnsupported { [MethodImpl] get; }

    public static extern string ActiveSync_RoomsSchedule { [MethodImpl] get; }

    public static extern string ActiveSync_AllEmailAddresses { [MethodImpl] get; }

    public static extern string ActiveSync_FailedDownloadAttachment { [MethodImpl] get; }

    public static extern string ActiveSync_ServerCertHashConfirmed { [MethodImpl] get; }

    public static extern string ActiveSync_ClientAuthCertNeeded { [MethodImpl] get; }

    public static extern string ActiveSync_AutoSelectAuthCert { [MethodImpl] get; }

    public static extern string ActiveSync_ServerIsWindowsLive { [MethodImpl] get; }

    public static extern string ActiveSync_ServerCertHash { [MethodImpl] get; }

    public static extern string ActiveSync_PreventAccountFromSyncing { [MethodImpl] get; }

    public static extern string ActiveSync_AuthCertId { [MethodImpl] get; }

    public static extern string ActiveSync_AcceptableClientCertificateIssuers { [MethodImpl] get; }

    public static extern string ActiveSync_AccountProtected { [MethodImpl] get; }

    public static extern string ActiveSync_SsoAuthSupported { [MethodImpl] get; }

    public static extern string ActiveSync_AccountProtectedDomain { [MethodImpl] get; }

    public static extern string ActiveSync_DeleteSupported { [MethodImpl] get; }

    public static extern string InternetMail_AccountServiceType { [MethodImpl] get; }

    public static extern string InternetMail_EmailDisplayName { [MethodImpl] get; }

    public static extern string InternetMail_Domain { [MethodImpl] get; }

    public static extern string InternetMail_UserName { [MethodImpl] get; }

    public static extern string InternetMail_Password { [MethodImpl] get; }

    public static extern string InternetMail_IncomingServer { [MethodImpl] get; }

    public static extern string InternetMail_IncomingServerUseSsl { [MethodImpl] get; }

    public static extern string InternetMail_OutgoingServer { [MethodImpl] get; }

    public static extern string InternetMail_OutgoingServerUseSsl { [MethodImpl] get; }

    public static extern string InternetMail_OutgoingServerAuthRequired { [MethodImpl] get; }

    public static extern string InternetMail_OutgoingServerAuthEnabled { [MethodImpl] get; }

    public static extern string InternetMail_OutgoingServerDomain { [MethodImpl] get; }

    public static extern string InternetMail_OutgoingServerUserName { [MethodImpl] get; }

    public static extern string InternetMail_OutgoingServerPassword { [MethodImpl] get; }

    public static extern string InternetMail_Schedule { [MethodImpl] get; }

    public static extern string InternetMail_DownloadDays { [MethodImpl] get; }

    public static extern string InternetMail_KeepMax { [MethodImpl] get; }

    public static extern string InternetMail_Retrieve { [MethodImpl] get; }

    public static extern string InternetMail_AccountType { [MethodImpl] get; }

    public static extern string InternetMail_UseCellularOnly { [MethodImpl] get; }

    public static extern string InternetMail_ServerDeleteAction { [MethodImpl] get; }

    public static extern string InternetMail_HasSynced { [MethodImpl] get; }

    public static extern string InternetMail_SyncingContentType { [MethodImpl] get; }

    public static extern string InternetMail_CardDavServerUrl { [MethodImpl] get; }

    public static extern string InternetMail_CardDavUseSSL { [MethodImpl] get; }

    public static extern string InternetMail_CalDavServerUrl { [MethodImpl] get; }

    public static extern string InternetMail_CalDavUseSSL { [MethodImpl] get; }

    public static extern string InternetMail_CardDavSyncFreq { [MethodImpl] get; }

    public static extern string InternetMail_CalDavSyncFreq { [MethodImpl] get; }

    public static extern string InternetMail_LastSMTPSuccess { [MethodImpl] get; }

    public static extern string InternetMail_AccountCreateTime { [MethodImpl] get; }

    public static extern string InternetMail_IncomingServerSettingsVerified { [MethodImpl] get; }

    public static extern string InternetMail_OutgoingServerSettingsVerified { [MethodImpl] get; }

    public static extern string InternetMail_UserInputSettings { [MethodImpl] get; }

    public static extern string InternetMail_ErrorSource { [MethodImpl] get; }

    public static extern string InternetMail_Engine { [MethodImpl] get; }

    public static extern string InternetMail_IsPushImapSupported { [MethodImpl] get; }

    public static extern string InternetMail_OtherMailSyncPeriod { [MethodImpl] get; }

    public static extern string InternetMail_LastCalendarSyncAttempt { [MethodImpl] get; }

    public static extern string InternetMail_CalendarAgeFilter { [MethodImpl] get; }

    public static extern string InternetMail_LastContactSyncAttempt { [MethodImpl] get; }

    public static extern string InternetMail_LastOtherMailSyncAttempt { [MethodImpl] get; }

    public static extern string InternetMail_PreventAccountFromSyncing { [MethodImpl] get; }

    public static extern string InternetMail_IncomingServerCertHashConfirmed { [MethodImpl] get; }

    public static extern string InternetMail_OutgoingServerCertHashConfirmed { [MethodImpl] get; }

    public static extern IVector<string> DefaultProperties { [MethodImpl] get; }

    public static extern IVector<string> ActiveSyncProperties { [MethodImpl] get; }

    public static extern IVector<string> InternetMailProperties { [MethodImpl] get; }
  }
}
