// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Sync.IAccountPropertiesStatics
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Sync
{
  [Guid(1855644849, 25085, 18808, 184, 19, 130, 188, 150, 135, 7, 105)]
  [Version(100859904)]
  [ExclusiveTo(typeof (AccountProperties))]
  internal interface IAccountPropertiesStatics
  {
    string Id { get; }

    string Name { get; }

    string Icon { get; }

    string EmailAddress { get; }

    string LastSyncSuccess { get; }

    string LastSyncAttempt { get; }

    string LastSyncResult { get; }

    string LastUsed { get; }

    string DeleteInProgress { get; }

    string SMIMEAlwaysEncrypt { get; }

    string SMIMEAlwaysSign { get; }

    string RequireEncryptedSMIMEMessages { get; }

    string RequireSignedSMIMEMessages { get; }

    string AllowSMIMEEncryptionAlgorithmNegotiation { get; }

    string AllowSMIMESoftCerts { get; }

    string RequiredEncryptionSMIMEAlgorithm { get; }

    string RequiredSignedSMIMEAlgorithm { get; }

    string AuthenticationType { get; }

    string RefreshToken { get; }

    string TokenExpiration { get; }

    string SSOAccountId { get; }

    string UserDataAccountId { get; }

    string AllowMailTruncation { get; }

    string AllowMailSync { get; }

    string InitialAutdHeartbeat { get; }

    string MinAutdHeartbeat { get; }

    string MaxAutdHeartbeat { get; }

    string AutdHeartbeatIncrement { get; }

    string AccountMigrated { get; }

    string IsExternallyManaged { get; }

    string ActiveSync_Type { get; }

    string ActiveSync_Server { get; }

    string ActiveSync_Domain { get; }

    string ActiveSync_UserName { get; }

    string ActiveSync_Password { get; }

    string ActiveSync_ServerUseSsl { get; }

    string ActiveSync_SyncFrequency { get; }

    string ActiveSync_CalendarAgeFilter { get; }

    string ActiveSync_MaxMailAgeFilter { get; }

    string ActiveSync_MailAgeFilter { get; }

    string ActiveSync_MailBodyType { get; }

    string ActiveSync_MailHTMLTruncation { get; }

    string ActiveSync_MailPlainTextTruncation { get; }

    string ActiveSync_ContactsEnabled { get; }

    string ActiveSync_CalendarEnabled { get; }

    string ActiveSync_MailEnabled { get; }

    string ActiveSync_TasksEnabled { get; }

    string ActiveSync_PhotoEnabled { get; }

    string ActiveSync_FeedsEnabled { get; }

    string ActiveSync_HasSynced { get; }

    string ActiveSync_IsDefaultAccount { get; }

    string ActiveSync_ConversationSyncEnabled { get; }

    string ActiveSync_DomainUnsupported { get; }

    string ActiveSync_RoomsSchedule { get; }

    string ActiveSync_AllEmailAddresses { get; }

    string ActiveSync_FailedDownloadAttachment { get; }

    string ActiveSync_ServerCertHashConfirmed { get; }

    string ActiveSync_ClientAuthCertNeeded { get; }

    string ActiveSync_AutoSelectAuthCert { get; }

    string ActiveSync_ServerIsWindowsLive { get; }

    string ActiveSync_ServerCertHash { get; }

    string ActiveSync_PreventAccountFromSyncing { get; }

    string ActiveSync_AuthCertId { get; }

    string ActiveSync_AcceptableClientCertificateIssuers { get; }

    string ActiveSync_AccountProtected { get; }

    string ActiveSync_SsoAuthSupported { get; }

    string ActiveSync_AccountProtectedDomain { get; }

    string ActiveSync_DeleteSupported { get; }

    string InternetMail_AccountServiceType { get; }

    string InternetMail_EmailDisplayName { get; }

    string InternetMail_Domain { get; }

    string InternetMail_UserName { get; }

    string InternetMail_Password { get; }

    string InternetMail_IncomingServer { get; }

    string InternetMail_IncomingServerUseSsl { get; }

    string InternetMail_OutgoingServer { get; }

    string InternetMail_OutgoingServerUseSsl { get; }

    string InternetMail_OutgoingServerAuthRequired { get; }

    string InternetMail_OutgoingServerAuthEnabled { get; }

    string InternetMail_OutgoingServerDomain { get; }

    string InternetMail_OutgoingServerUserName { get; }

    string InternetMail_OutgoingServerPassword { get; }

    string InternetMail_Schedule { get; }

    string InternetMail_DownloadDays { get; }

    string InternetMail_KeepMax { get; }

    string InternetMail_Retrieve { get; }

    string InternetMail_AccountType { get; }

    string InternetMail_UseCellularOnly { get; }

    string InternetMail_ServerDeleteAction { get; }

    string InternetMail_HasSynced { get; }

    string InternetMail_SyncingContentType { get; }

    string InternetMail_CardDavServerUrl { get; }

    string InternetMail_CardDavUseSSL { get; }

    string InternetMail_CalDavServerUrl { get; }

    string InternetMail_CalDavUseSSL { get; }

    string InternetMail_CardDavSyncFreq { get; }

    string InternetMail_CalDavSyncFreq { get; }

    string InternetMail_LastSMTPSuccess { get; }

    string InternetMail_AccountCreateTime { get; }

    string InternetMail_IncomingServerSettingsVerified { get; }

    string InternetMail_OutgoingServerSettingsVerified { get; }

    string InternetMail_UserInputSettings { get; }

    string InternetMail_ErrorSource { get; }

    string InternetMail_Engine { get; }

    string InternetMail_IsPushImapSupported { get; }

    string InternetMail_OtherMailSyncPeriod { get; }

    string InternetMail_LastCalendarSyncAttempt { get; }

    string InternetMail_CalendarAgeFilter { get; }

    string InternetMail_LastContactSyncAttempt { get; }

    string InternetMail_LastOtherMailSyncAttempt { get; }

    string InternetMail_PreventAccountFromSyncing { get; }

    string InternetMail_IncomingServerCertHashConfirmed { get; }

    string InternetMail_OutgoingServerCertHashConfirmed { get; }

    IVector<string> DefaultProperties { get; }

    IVector<string> ActiveSyncProperties { get; }

    IVector<string> InternetMailProperties { get; }
  }
}
