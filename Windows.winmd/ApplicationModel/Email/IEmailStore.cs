// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailStore))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4160954990, 37175, 20363, 164, 112, 39, 154, 195, 5, 142, 182)]
  internal interface IEmailStore
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<EmailMailbox>> FindMailboxesAsync();

    [Overload("GetConversationReader")]
    EmailConversationReader GetConversationReader();

    [Overload("GetConversationReaderWithOptions")]
    EmailConversationReader GetConversationReader(EmailQueryOptions options);

    [Overload("GetMessageReader")]
    EmailMessageReader GetMessageReader();

    [Overload("GetMessageReaderWithOptions")]
    EmailMessageReader GetMessageReader(EmailQueryOptions options);

    [RemoteAsync]
    IAsyncOperation<EmailMailbox> GetMailboxAsync(string id);

    [RemoteAsync]
    IAsyncOperation<EmailConversation> GetConversationAsync(
      string id);

    [RemoteAsync]
    IAsyncOperation<EmailFolder> GetFolderAsync(string id);

    [RemoteAsync]
    IAsyncOperation<EmailMessage> GetMessageAsync(string id);

    [RemoteAsync]
    [Overload("CreateMailboxAsync")]
    IAsyncOperation<EmailMailbox> CreateMailboxAsync(
      string accountName,
      string accountAddress);

    [RemoteAsync]
    [Overload("CreateMailboxInAccountAsync")]
    IAsyncOperation<EmailMailbox> CreateMailboxAsync(
      string accountName,
      string accountAddress,
      string userDataAccountId);
  }
}
