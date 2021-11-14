// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ChatMessage : 
    IChatMessage,
    IChatMessage2,
    IChatMessage3,
    IChatMessage4,
    IChatItem
  {
    [MethodImpl]
    public extern ChatMessage();

    public extern IVector<ChatMessageAttachment> Attachments { [MethodImpl] get; }

    public extern string Body { [MethodImpl] get; [MethodImpl] set; }

    public extern string From { [MethodImpl] get; [MethodImpl] set; }

    public extern string Id { [MethodImpl] get; }

    public extern bool IsForwardingDisabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsIncoming { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsRead { [MethodImpl] get; [MethodImpl] set; }

    public extern DateTime LocalTimestamp { [MethodImpl] get; [MethodImpl] set; }

    public extern DateTime NetworkTimestamp { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> Recipients { [MethodImpl] get; }

    public extern IMapView<string, ChatMessageStatus> RecipientSendStatuses { [MethodImpl] get; }

    public extern ChatMessageStatus Status { [MethodImpl] get; [MethodImpl] set; }

    public extern string Subject { [MethodImpl] get; [MethodImpl] set; }

    public extern string TransportFriendlyName { [MethodImpl] get; }

    public extern string TransportId { [MethodImpl] get; [MethodImpl] set; }

    public extern ulong EstimatedDownloadSize { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsAutoReply { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsReplyDisabled { [MethodImpl] get; }

    public extern bool IsSeen { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsSimMessage { [MethodImpl] get; }

    public extern ChatMessageKind MessageKind { [MethodImpl] get; [MethodImpl] set; }

    public extern ChatMessageOperatorKind MessageOperatorKind { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsReceivedDuringQuietHours { [MethodImpl] get; [MethodImpl] set; }

    public extern string RemoteId { [MethodImpl] set; [MethodImpl] get; }

    public extern bool ShouldSuppressNotification { [MethodImpl] get; [MethodImpl] set; }

    public extern ChatConversationThreadingInfo ThreadingInfo { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<ChatRecipientDeliveryInfo> RecipientsDeliveryInfos { [MethodImpl] get; }

    public extern string SyncId { [MethodImpl] get; [MethodImpl] set; }

    public extern ChatItemKind ItemKind { [MethodImpl] get; }
  }
}
