// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatConversation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ChatConversation : IChatConversation, IChatConversation2, IChatItem
  {
    public extern bool HasUnreadMessages { [MethodImpl] get; }

    public extern string Id { [MethodImpl] get; }

    public extern string Subject { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsConversationMuted { [MethodImpl] get; [MethodImpl] set; }

    public extern string MostRecentMessageId { [MethodImpl] get; }

    public extern IVector<string> Participants { [MethodImpl] get; }

    public extern ChatConversationThreadingInfo ThreadingInfo { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    [MethodImpl]
    public extern ChatMessageReader GetMessageReader();

    [RemoteAsync]
    [Overload("MarkAllMessagesAsReadAsync")]
    [MethodImpl]
    public extern IAsyncAction MarkMessagesAsReadAsync();

    [Overload("MarkMessagesAsReadAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MarkMessagesAsReadAsync(DateTime value);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveAsync();

    [MethodImpl]
    public extern void NotifyLocalParticipantComposing(
      string transportId,
      string participantAddress,
      bool isComposing);

    [MethodImpl]
    public extern void NotifyRemoteParticipantComposing(
      string transportId,
      string participantAddress,
      bool isComposing);

    public extern event TypedEventHandler<ChatConversation, RemoteParticipantComposingChangedEventArgs> RemoteParticipantComposingChanged;

    public extern bool CanModifyParticipants { [MethodImpl] get; [MethodImpl] set; }

    public extern ChatItemKind ItemKind { [MethodImpl] get; }
  }
}
