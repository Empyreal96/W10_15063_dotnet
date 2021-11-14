// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailbox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(2826503753, 53083, 16667, 128, 177, 74, 106, 20, 132, 206, 37)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EmailMailbox))]
  internal interface IEmailMailbox
  {
    EmailMailboxCapabilities Capabilities { get; }

    EmailMailboxChangeTracker ChangeTracker { get; }

    string DisplayName { get; set; }

    string Id { get; }

    bool IsOwnedByCurrentApp { get; }

    bool IsDataEncryptedUnderLock { get; }

    string MailAddress { get; set; }

    IVector<string> MailAddressAliases { get; }

    EmailMailboxOtherAppReadAccess OtherAppReadAccess { get; set; }

    EmailMailboxOtherAppWriteAccess OtherAppWriteAccess { get; set; }

    EmailMailboxPolicies Policies { get; }

    string SourceDisplayName { get; }

    EmailMailboxSyncManager SyncManager { get; }

    string UserDataAccountId { get; }

    [Overload("GetConversationReader")]
    EmailConversationReader GetConversationReader();

    [Overload("GetConversationReaderWithOptions")]
    EmailConversationReader GetConversationReader(EmailQueryOptions options);

    [Overload("GetMessageReader")]
    EmailMessageReader GetMessageReader();

    [Overload("GetMessageReaderWithOptions")]
    EmailMessageReader GetMessageReader(EmailQueryOptions options);

    [RemoteAsync]
    IAsyncAction DeleteAsync();

    [RemoteAsync]
    IAsyncOperation<EmailConversation> GetConversationAsync(
      string id);

    [RemoteAsync]
    IAsyncOperation<EmailFolder> GetFolderAsync(string id);

    [RemoteAsync]
    IAsyncOperation<EmailMessage> GetMessageAsync(string id);

    [RemoteAsync]
    IAsyncOperation<EmailFolder> GetSpecialFolderAsync(
      EmailSpecialFolderKind folderType);

    [RemoteAsync]
    IAsyncAction SaveAsync();

    [RemoteAsync]
    IAsyncAction MarkMessageAsSeenAsync(string messageId);

    [RemoteAsync]
    IAsyncAction MarkFolderAsSeenAsync(string folderId);

    [RemoteAsync]
    IAsyncAction MarkMessageReadAsync(string messageId, bool isRead);

    [RemoteAsync]
    IAsyncAction ChangeMessageFlagStateAsync(string messageId, EmailFlagState flagState);

    [RemoteAsync]
    IAsyncOperation<bool> TryMoveMessageAsync(
      string messageId,
      string newParentFolderId);

    [Overload("TryMoveFolderAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> TryMoveFolderAsync(
      string folderId,
      string newParentFolderId);

    [RemoteAsync]
    [Overload("TryMoveFolderWithNewNameAsync")]
    IAsyncOperation<bool> TryMoveFolderAsync(
      string folderId,
      string newParentFolderId,
      string newFolderName);

    [RemoteAsync]
    IAsyncAction DeleteMessageAsync(string messageId);

    [RemoteAsync]
    IAsyncAction MarkFolderSyncEnabledAsync(string folderId, bool isSyncEnabled);

    [Overload("SendMessageAsync")]
    IAsyncAction SendMessageAsync(EmailMessage message);

    IAsyncAction SaveDraftAsync(EmailMessage message);

    [RemoteAsync]
    IAsyncAction DownloadMessageAsync(string messageId);

    [RemoteAsync]
    IAsyncAction DownloadAttachmentAsync(string attachmentId);

    [RemoteAsync]
    IAsyncOperation<EmailMessage> CreateResponseMessageAsync(
      string messageId,
      EmailMessageResponseKind responseType,
      string subject,
      EmailMessageBodyKind responseHeaderType,
      string responseHeader);

    IAsyncOperation<bool> TryUpdateMeetingResponseAsync(
      EmailMessage meeting,
      EmailMeetingResponseType response,
      string subject,
      string comment,
      bool sendUpdate);

    IAsyncOperation<bool> TryForwardMeetingAsync(
      EmailMessage meeting,
      IIterable<EmailRecipient> recipients,
      string subject,
      EmailMessageBodyKind forwardHeaderType,
      string forwardHeader,
      string comment);

    IAsyncOperation<bool> TryProposeNewTimeForMeetingAsync(
      EmailMessage meeting,
      DateTime newStartTime,
      TimeSpan newDuration,
      string subject,
      string comment);

    event TypedEventHandler<EmailMailbox, EmailMailboxChangedEventArgs> MailboxChanged;

    [Overload("SmartSendMessageAsync")]
    IAsyncAction SendMessageAsync(EmailMessage message, bool smartSend);

    IAsyncOperation<bool> TrySetAutoReplySettingsAsync(
      EmailMailboxAutoReplySettings autoReplySettings);

    [RemoteAsync]
    IAsyncOperation<EmailMailboxAutoReplySettings> TryGetAutoReplySettingsAsync(
      EmailMailboxAutoReplyMessageResponseKind requestedFormat);
  }
}
