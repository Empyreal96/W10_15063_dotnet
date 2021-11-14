// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailConversation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EmailConversation))]
  [Guid(3659055688, 41148, 17225, 144, 45, 144, 246, 99, 137, 245, 27)]
  internal interface IEmailConversation
  {
    string Id { get; }

    string MailboxId { get; }

    EmailFlagState FlagState { get; }

    bool HasAttachment { get; }

    EmailImportance Importance { get; }

    EmailMessageResponseKind LastEmailResponseKind { get; }

    uint MessageCount { get; }

    string MostRecentMessageId { get; }

    DateTime MostRecentMessageTime { get; }

    string Preview { get; }

    EmailRecipient LatestSender { get; }

    string Subject { get; }

    uint UnreadMessageCount { get; }

    [RemoteAsync]
    [Overload("FindMessagesAsync")]
    IAsyncOperation<IVectorView<EmailMessage>> FindMessagesAsync();

    [Overload("FindMessagesWithCountAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<EmailMessage>> FindMessagesAsync(
      uint count);
  }
}
