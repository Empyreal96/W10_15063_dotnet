// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailConversation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class EmailConversation : IEmailConversation
  {
    public extern string Id { [MethodImpl] get; }

    public extern string MailboxId { [MethodImpl] get; }

    public extern EmailFlagState FlagState { [MethodImpl] get; }

    public extern bool HasAttachment { [MethodImpl] get; }

    public extern EmailImportance Importance { [MethodImpl] get; }

    public extern EmailMessageResponseKind LastEmailResponseKind { [MethodImpl] get; }

    public extern uint MessageCount { [MethodImpl] get; }

    public extern string MostRecentMessageId { [MethodImpl] get; }

    public extern DateTime MostRecentMessageTime { [MethodImpl] get; }

    public extern string Preview { [MethodImpl] get; }

    public extern EmailRecipient LatestSender { [MethodImpl] get; }

    public extern string Subject { [MethodImpl] get; }

    public extern uint UnreadMessageCount { [MethodImpl] get; }

    [Overload("FindMessagesAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<EmailMessage>> FindMessagesAsync();

    [Overload("FindMessagesWithCountAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<EmailMessage>> FindMessagesAsync(
      uint count);
  }
}
