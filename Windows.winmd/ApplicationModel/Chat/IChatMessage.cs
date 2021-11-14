// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ChatMessage))]
  [Guid(1262028074, 4418, 20617, 118, 218, 242, 219, 61, 23, 205, 5)]
  internal interface IChatMessage
  {
    IVector<ChatMessageAttachment> Attachments { get; }

    string Body { get; set; }

    string From { get; }

    string Id { get; }

    bool IsForwardingDisabled { get; }

    bool IsIncoming { get; }

    bool IsRead { get; }

    DateTime LocalTimestamp { get; }

    DateTime NetworkTimestamp { get; }

    IVector<string> Recipients { get; }

    IMapView<string, ChatMessageStatus> RecipientSendStatuses { get; }

    ChatMessageStatus Status { get; }

    string Subject { get; }

    string TransportFriendlyName { get; }

    string TransportId { get; set; }
  }
}
