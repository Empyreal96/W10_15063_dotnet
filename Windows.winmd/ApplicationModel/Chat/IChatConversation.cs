// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatConversation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ChatConversation))]
  [Guid(2777417741, 6767, 18140, 143, 61, 245, 2, 134, 96, 182, 238)]
  internal interface IChatConversation
  {
    bool HasUnreadMessages { get; }

    string Id { get; }

    string Subject { get; set; }

    bool IsConversationMuted { get; set; }

    string MostRecentMessageId { get; }

    IVector<string> Participants { get; }

    ChatConversationThreadingInfo ThreadingInfo { get; }

    [RemoteAsync]
    IAsyncAction DeleteAsync();

    ChatMessageReader GetMessageReader();

    [Overload("MarkAllMessagesAsReadAsync")]
    [RemoteAsync]
    IAsyncAction MarkMessagesAsReadAsync();

    [RemoteAsync]
    [Overload("MarkMessagesAsReadAsync")]
    IAsyncAction MarkMessagesAsReadAsync(DateTime value);

    [RemoteAsync]
    IAsyncAction SaveAsync();

    void NotifyLocalParticipantComposing(
      string transportId,
      string participantAddress,
      bool isComposing);

    void NotifyRemoteParticipantComposing(
      string transportId,
      string participantAddress,
      bool isComposing);

    event TypedEventHandler<ChatConversation, RemoteParticipantComposingChangedEventArgs> RemoteParticipantComposingChanged;
  }
}
