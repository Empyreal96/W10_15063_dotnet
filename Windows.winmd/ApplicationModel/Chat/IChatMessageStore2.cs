// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageStore2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ChatMessageStore))]
  [Guid(2907555054, 15060, 18715, 179, 17, 171, 223, 155, 178, 39, 104)]
  internal interface IChatMessageStore2 : IChatMessageStore
  {
    [RemoteAsync]
    IAsyncOperation<ChatMessage> ForwardMessageAsync(
      string localChatMessageId,
      IIterable<string> addresses);

    [RemoteAsync]
    [Overload("GetConversationAsync")]
    IAsyncOperation<ChatConversation> GetConversationAsync(
      string conversationId);

    [RemoteAsync]
    [Overload("GetConversationForTransportsAsync")]
    IAsyncOperation<ChatConversation> GetConversationAsync(
      string conversationId,
      IIterable<string> transportIds);

    IAsyncOperation<ChatConversation> GetConversationFromThreadingInfoAsync(
      ChatConversationThreadingInfo threadingInfo);

    [Overload("GetConversationReader")]
    ChatConversationReader GetConversationReader();

    [Overload("GetConversationForTransportsReader")]
    ChatConversationReader GetConversationReader(
      IIterable<string> transportIds);

    [RemoteAsync]
    IAsyncOperation<ChatMessage> GetMessageByRemoteIdAsync(
      string transportId,
      string remoteId);

    [Overload("GetUnseenCountAsync")]
    [RemoteAsync]
    IAsyncOperation<int> GetUnseenCountAsync();

    [Overload("GetUnseenCountForTransportsReaderAsync")]
    IAsyncOperation<int> GetUnseenCountAsync(IIterable<string> transportIds);

    [RemoteAsync]
    [Overload("MarkAsSeenAsync")]
    IAsyncAction MarkAsSeenAsync();

    [Overload("MarkAsSeenForTransportsAsync")]
    IAsyncAction MarkAsSeenAsync(IIterable<string> transportIds);

    ChatSearchReader GetSearchReader(ChatQueryOptions value);

    IAsyncAction SaveMessageAsync(ChatMessage chatMessage);

    [RemoteAsync]
    IAsyncOperation<bool> TryCancelDownloadMessageAsync(string localChatMessageId);

    [RemoteAsync]
    IAsyncOperation<bool> TryCancelSendMessageAsync(string localChatMessageId);

    event TypedEventHandler<ChatMessageStore, ChatMessageStoreChangedEventArgs> StoreChanged;
  }
}
