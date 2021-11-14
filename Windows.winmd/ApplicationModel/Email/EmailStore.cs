// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailStore
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
  public sealed class EmailStore : IEmailStore
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<EmailMailbox>> FindMailboxesAsync();

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
    public extern IAsyncOperation<EmailMailbox> GetMailboxAsync(string id);

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
    [Overload("CreateMailboxAsync")]
    [MethodImpl]
    public extern IAsyncOperation<EmailMailbox> CreateMailboxAsync(
      string accountName,
      string accountAddress);

    [Overload("CreateMailboxInAccountAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailMailbox> CreateMailboxAsync(
      string accountName,
      string accountAddress,
      string userDataAccountId);
  }
}
