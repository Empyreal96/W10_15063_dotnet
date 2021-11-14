// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Guid(838008065, 52470, 22539, 73, 118, 10, 7, 221, 93, 59, 71)]
  [ExclusiveTo(typeof (ChatMessageStore))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IChatMessageStore
  {
    ChatMessageChangeTracker ChangeTracker { get; }

    [RemoteAsync]
    IAsyncAction DeleteMessageAsync(string localMessageId);

    [RemoteAsync]
    IAsyncAction DownloadMessageAsync(string localChatMessageId);

    [RemoteAsync]
    IAsyncOperation<ChatMessage> GetMessageAsync(string localChatMessageId);

    [Overload("GetMessageReader1")]
    ChatMessageReader GetMessageReader();

    [Overload("GetMessageReader2")]
    ChatMessageReader GetMessageReader(TimeSpan recentTimeLimit);

    [RemoteAsync]
    IAsyncAction MarkMessageReadAsync(string localChatMessageId);

    [RemoteAsync]
    IAsyncAction RetrySendMessageAsync(string localChatMessageId);

    IAsyncAction SendMessageAsync(ChatMessage chatMessage);

    ChatMessageValidationResult ValidateMessage(ChatMessage chatMessage);

    event TypedEventHandler<ChatMessageStore, ChatMessageChangedEventArgs> MessageChanged;
  }
}
