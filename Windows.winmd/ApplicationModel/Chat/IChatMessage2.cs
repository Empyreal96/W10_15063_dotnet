// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessage2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2254865202, 21567, 18933, 172, 113, 108, 42, 252, 101, 101, 253)]
  [ExclusiveTo(typeof (ChatMessage))]
  internal interface IChatMessage2 : IChatMessage3, IChatMessage
  {
    ulong EstimatedDownloadSize { get; set; }

    new string From { set; }

    bool IsAutoReply { get; set; }

    new bool IsForwardingDisabled { set; }

    bool IsReplyDisabled { get; }

    new bool IsIncoming { set; }

    new bool IsRead { set; }

    bool IsSeen { get; set; }

    bool IsSimMessage { get; }

    new DateTime LocalTimestamp { set; }

    ChatMessageKind MessageKind { get; set; }

    ChatMessageOperatorKind MessageOperatorKind { get; set; }

    new DateTime NetworkTimestamp { set; }

    bool IsReceivedDuringQuietHours { get; set; }

    new string RemoteId { set; }

    new ChatMessageStatus Status { set; }

    new string Subject { set; }

    bool ShouldSuppressNotification { get; set; }

    ChatConversationThreadingInfo ThreadingInfo { get; set; }

    IVector<ChatRecipientDeliveryInfo> RecipientsDeliveryInfos { get; }
  }
}
