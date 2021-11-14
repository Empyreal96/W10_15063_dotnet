// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMessage2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailMessage))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4257752203, 40730, 17627, 189, 60, 101, 195, 132, 119, 15, 134)]
  internal interface IEmailMessage2
  {
    string Id { get; }

    string RemoteId { get; set; }

    string MailboxId { get; }

    string ConversationId { get; }

    string FolderId { get; }

    bool AllowInternetImages { get; set; }

    ulong ChangeNumber { get; }

    EmailMessageDownloadState DownloadState { get; set; }

    uint EstimatedDownloadSizeInBytes { get; set; }

    EmailFlagState FlagState { get; set; }

    bool HasPartialBodies { get; }

    EmailImportance Importance { get; set; }

    string InResponseToMessageId { get; }

    EmailIrmInfo IrmInfo { get; set; }

    bool IsDraftMessage { get; }

    bool IsRead { get; set; }

    bool IsSeen { get; set; }

    bool IsServerSearchMessage { get; }

    bool IsSmartSendable { get; }

    string MessageClass { get; set; }

    string NormalizedSubject { get; }

    int OriginalCodePage { get; set; }

    string Preview { get; set; }

    EmailMessageResponseKind LastResponseKind { get; set; }

    EmailRecipient Sender { get; set; }

    IReference<DateTime> SentTime { get; set; }

    EmailMeetingInfo MeetingInfo { get; set; }

    IRandomAccessStreamReference GetBodyStream(EmailMessageBodyKind type);

    void SetBodyStream(EmailMessageBodyKind type, IRandomAccessStreamReference stream);
  }
}
