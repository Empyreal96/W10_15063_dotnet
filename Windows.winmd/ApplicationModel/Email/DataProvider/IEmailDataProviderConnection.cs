// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailDataProviderConnection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (EmailDataProviderConnection))]
  [Guid(1000119751, 14258, 19440, 174, 48, 123, 100, 74, 28, 150, 225)]
  internal interface IEmailDataProviderConnection
  {
    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxSyncManagerSyncRequestEventArgs> MailboxSyncRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxDownloadMessageRequestEventArgs> DownloadMessageRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxDownloadAttachmentRequestEventArgs> DownloadAttachmentRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxCreateFolderRequestEventArgs> CreateFolderRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxDeleteFolderRequestEventArgs> DeleteFolderRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxEmptyFolderRequestEventArgs> EmptyFolderRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxMoveFolderRequestEventArgs> MoveFolderRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxUpdateMeetingResponseRequestEventArgs> UpdateMeetingResponseRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxForwardMeetingRequestEventArgs> ForwardMeetingRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxProposeNewTimeForMeetingRequestEventArgs> ProposeNewTimeForMeetingRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxSetAutoReplySettingsRequestEventArgs> SetAutoReplySettingsRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxGetAutoReplySettingsRequestEventArgs> GetAutoReplySettingsRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxResolveRecipientsRequestEventArgs> ResolveRecipientsRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxValidateCertificatesRequestEventArgs> ValidateCertificatesRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxServerSearchReadBatchRequestEventArgs> ServerSearchReadBatchRequested;

    void Start();
  }
}
