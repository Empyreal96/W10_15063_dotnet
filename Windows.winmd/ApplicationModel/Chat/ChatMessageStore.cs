// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ChatMessageStore : IChatMessageStore, IChatMessageStore2, IChatMessageStore3
  {
    public extern ChatMessageChangeTracker ChangeTracker { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteMessageAsync(string localMessageId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DownloadMessageAsync(string localChatMessageId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ChatMessage> GetMessageAsync(
      string localChatMessageId);

    [Overload("GetMessageReader1")]
    [MethodImpl]
    public extern ChatMessageReader GetMessageReader();

    [Overload("GetMessageReader2")]
    [MethodImpl]
    public extern ChatMessageReader GetMessageReader(TimeSpan recentTimeLimit);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MarkMessageReadAsync(string localChatMessageId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RetrySendMessageAsync(string localChatMessageId);

    [MethodImpl]
    public extern IAsyncAction SendMessageAsync(ChatMessage chatMessage);

    [MethodImpl]
    public extern ChatMessageValidationResult ValidateMessage(
      ChatMessage chatMessage);

    public extern event TypedEventHandler<ChatMessageStore, ChatMessageChangedEventArgs> MessageChanged;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ChatMessage> ForwardMessageAsync(
      string localChatMessageId,
      IIterable<string> addresses);

    [RemoteAsync]
    [Overload("GetConversationAsync")]
    [MethodImpl]
    public extern IAsyncOperation<ChatConversation> GetConversationAsync(
      string conversationId);

    [Overload("GetConversationForTransportsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ChatConversation> GetConversationAsync(
      string conversationId,
      IIterable<string> transportIds);

    [MethodImpl]
    public extern IAsyncOperation<ChatConversation> GetConversationFromThreadingInfoAsync(
      ChatConversationThreadingInfo threadingInfo);

    [Overload("GetConversationReader")]
    [MethodImpl]
    public extern ChatConversationReader GetConversationReader();

    [Overload("GetConversationForTransportsReader")]
    [MethodImpl]
    public extern ChatConversationReader GetConversationReader(
      IIterable<string> transportIds);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ChatMessage> GetMessageByRemoteIdAsync(
      string transportId,
      string remoteId);

    [Overload("GetUnseenCountAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<int> GetUnseenCountAsync();

    [Overload("GetUnseenCountForTransportsReaderAsync")]
    [MethodImpl]
    public extern IAsyncOperation<int> GetUnseenCountAsync(
      IIterable<string> transportIds);

    [Overload("MarkAsSeenAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MarkAsSeenAsync();

    [Overload("MarkAsSeenForTransportsAsync")]
    [MethodImpl]
    public extern IAsyncAction MarkAsSeenAsync(IIterable<string> transportIds);

    [MethodImpl]
    public extern ChatSearchReader GetSearchReader(ChatQueryOptions value);

    [MethodImpl]
    public extern IAsyncAction SaveMessageAsync(ChatMessage chatMessage);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryCancelDownloadMessageAsync(
      string localChatMessageId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryCancelSendMessageAsync(
      string localChatMessageId);

    public extern event TypedEventHandler<ChatMessageStore, ChatMessageStoreChangedEventArgs> StoreChanged;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ChatMessage> GetMessageBySyncIdAsync(
      string syncId);
  }
}
