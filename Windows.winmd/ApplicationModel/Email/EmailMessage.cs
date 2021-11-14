// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class EmailMessage : IEmailMessage, IEmailMessage2, IEmailMessage3, IEmailMessage4
  {
    [MethodImpl]
    public extern EmailMessage();

    public extern string Subject { [MethodImpl] get; [MethodImpl] set; }

    public extern string Body { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<EmailRecipient> To { [MethodImpl] get; }

    public extern IVector<EmailRecipient> CC { [MethodImpl] get; }

    public extern IVector<EmailRecipient> Bcc { [MethodImpl] get; }

    public extern IVector<EmailAttachment> Attachments { [MethodImpl] get; }

    public extern string Id { [MethodImpl] get; }

    public extern string RemoteId { [MethodImpl] get; [MethodImpl] set; }

    public extern string MailboxId { [MethodImpl] get; }

    public extern string ConversationId { [MethodImpl] get; }

    public extern string FolderId { [MethodImpl] get; }

    public extern bool AllowInternetImages { [MethodImpl] get; [MethodImpl] set; }

    public extern ulong ChangeNumber { [MethodImpl] get; }

    public extern EmailMessageDownloadState DownloadState { [MethodImpl] get; [MethodImpl] set; }

    public extern uint EstimatedDownloadSizeInBytes { [MethodImpl] get; [MethodImpl] set; }

    public extern EmailFlagState FlagState { [MethodImpl] get; [MethodImpl] set; }

    public extern bool HasPartialBodies { [MethodImpl] get; }

    public extern EmailImportance Importance { [MethodImpl] get; [MethodImpl] set; }

    public extern string InResponseToMessageId { [MethodImpl] get; }

    public extern EmailIrmInfo IrmInfo { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsDraftMessage { [MethodImpl] get; }

    public extern bool IsRead { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsSeen { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsServerSearchMessage { [MethodImpl] get; }

    public extern bool IsSmartSendable { [MethodImpl] get; }

    public extern string MessageClass { [MethodImpl] get; [MethodImpl] set; }

    public extern string NormalizedSubject { [MethodImpl] get; }

    public extern int OriginalCodePage { [MethodImpl] get; [MethodImpl] set; }

    public extern string Preview { [MethodImpl] get; [MethodImpl] set; }

    public extern EmailMessageResponseKind LastResponseKind { [MethodImpl] get; [MethodImpl] set; }

    public extern EmailRecipient Sender { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<DateTime> SentTime { [MethodImpl] get; [MethodImpl] set; }

    public extern EmailMeetingInfo MeetingInfo { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern IRandomAccessStreamReference GetBodyStream(
      EmailMessageBodyKind type);

    [MethodImpl]
    public extern void SetBodyStream(EmailMessageBodyKind type, IRandomAccessStreamReference stream);

    public extern IRandomAccessStreamReference SmimeData { [MethodImpl] get; [MethodImpl] set; }

    public extern EmailMessageSmimeKind SmimeKind { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<EmailRecipient> ReplyTo { [MethodImpl] get; }

    public extern EmailRecipient SentRepresenting { [MethodImpl] get; [MethodImpl] set; }
  }
}
