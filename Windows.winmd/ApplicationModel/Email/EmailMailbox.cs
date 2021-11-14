// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMailbox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.ApplicationModel.Email
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class EmailMailbox : IEmailMailbox, IEmailMailbox2, IEmailMailbox3, IEmailMailbox4
  {
    public extern EmailMailboxCapabilities Capabilities { [MethodImpl] get; }

    public extern EmailMailboxChangeTracker ChangeTracker { [MethodImpl] get; }

    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    public extern string Id { [MethodImpl] get; }

    public extern bool IsOwnedByCurrentApp { [MethodImpl] get; }

    public extern bool IsDataEncryptedUnderLock { [MethodImpl] get; }

    public extern string MailAddress { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> MailAddressAliases { [MethodImpl] get; }

    public extern EmailMailboxOtherAppReadAccess OtherAppReadAccess { [MethodImpl] get; [MethodImpl] set; }

    public extern EmailMailboxOtherAppWriteAccess OtherAppWriteAccess { [MethodImpl] get; [MethodImpl] set; }

    public extern EmailMailboxPolicies Policies { [MethodImpl] get; }

    public extern string SourceDisplayName { [MethodImpl] get; }

    public extern EmailMailboxSyncManager SyncManager { [MethodImpl] get; }

    public extern string UserDataAccountId { [MethodImpl] get; }

    [Overload("GetConversationReader")]
    [MethodImpl]
    public extern EmailConversationReader GetConversationReader();

    [Overload("GetConversationReaderWithOptions")]
    [MethodImpl]
    public extern EmailConversationReader GetConversationReader(
      EmailQueryOptions options);

    [Overload("GetMessageReader")]
    [MethodImpl]
    public extern EmailMessageReader GetMessageReader();

    [Overload("GetMessageReaderWithOptions")]
    [MethodImpl]
    public extern EmailMessageReader GetMessageReader(EmailQueryOptions options);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailConversation> GetConversationAsync(
      string id);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailFolder> GetFolderAsync(string id);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailMessage> GetMessageAsync(string id);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailFolder> GetSpecialFolderAsync(
      EmailSpecialFolderKind folderType);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MarkMessageAsSeenAsync(string messageId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MarkFolderAsSeenAsync(string folderId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MarkMessageReadAsync(string messageId, bool isRead);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ChangeMessageFlagStateAsync(
      string messageId,
      EmailFlagState flagState);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryMoveMessageAsync(
      string messageId,
      string newParentFolderId);

    [RemoteAsync]
    [Overload("TryMoveFolderAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryMoveFolderAsync(
      string folderId,
      string newParentFolderId);

    [Overload("TryMoveFolderWithNewNameAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryMoveFolderAsync(
      string folderId,
      string newParentFolderId,
      string newFolderName);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteMessageAsync(string messageId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MarkFolderSyncEnabledAsync(
      string folderId,
      bool isSyncEnabled);

    [Overload("SendMessageAsync")]
    [MethodImpl]
    public extern IAsyncAction SendMessageAsync(EmailMessage message);

    [MethodImpl]
    public extern IAsyncAction SaveDraftAsync(EmailMessage message);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DownloadMessageAsync(string messageId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DownloadAttachmentAsync(string attachmentId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailMessage> CreateResponseMessageAsync(
      string messageId,
      EmailMessageResponseKind responseType,
      string subject,
      EmailMessageBodyKind responseHeaderType,
      string responseHeader);

    [MethodImpl]
    public extern IAsyncOperation<bool> TryUpdateMeetingResponseAsync(
      EmailMessage meeting,
      EmailMeetingResponseType response,
      string subject,
      string comment,
      bool sendUpdate);

    [MethodImpl]
    public extern IAsyncOperation<bool> TryForwardMeetingAsync(
      EmailMessage meeting,
      IIterable<EmailRecipient> recipients,
      string subject,
      EmailMessageBodyKind forwardHeaderType,
      string forwardHeader,
      string comment);

    [MethodImpl]
    public extern IAsyncOperation<bool> TryProposeNewTimeForMeetingAsync(
      EmailMessage meeting,
      DateTime newStartTime,
      TimeSpan newDuration,
      string subject,
      string comment);

    public extern event TypedEventHandler<EmailMailbox, EmailMailboxChangedEventArgs> MailboxChanged;

    [Overload("SmartSendMessageAsync")]
    [MethodImpl]
    public extern IAsyncAction SendMessageAsync(EmailMessage message, bool smartSend);

    [MethodImpl]
    public extern IAsyncOperation<bool> TrySetAutoReplySettingsAsync(
      EmailMailboxAutoReplySettings autoReplySettings);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailMailboxAutoReplySettings> TryGetAutoReplySettingsAsync(
      EmailMailboxAutoReplyMessageResponseKind requestedFormat);

    public extern string LinkedMailboxId { [MethodImpl] get; }

    public extern string NetworkAccountId { [MethodImpl] get; }

    public extern string NetworkId { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<EmailRecipientResolutionResult>> ResolveRecipientsAsync(
      IIterable<string> recipients);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<EmailCertificateValidationStatus>> ValidateCertificatesAsync(
      IIterable<Certificate> certificates);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailMailboxEmptyFolderStatus> TryEmptyFolderAsync(
      string folderId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailMailboxCreateFolderResult> TryCreateFolderAsync(
      string parentFolderId,
      string name);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailMailboxDeleteFolderStatus> TryDeleteFolderAsync(
      string folderId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RegisterSyncManagerAsync();
  }
}
