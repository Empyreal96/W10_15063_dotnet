// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatRecipientDeliveryInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ChatRecipientDeliveryInfo))]
  [Guid(4291277474, 10300, 19466, 138, 14, 140, 51, 189, 191, 5, 69)]
  internal interface IChatRecipientDeliveryInfo
  {
    string TransportAddress { get; set; }

    IReference<DateTime> DeliveryTime { get; set; }

    IReference<DateTime> ReadTime { get; set; }

    ChatTransportErrorCodeCategory TransportErrorCodeCategory { get; }

    ChatTransportInterpretedErrorCode TransportInterpretedErrorCode { get; }

    int TransportErrorCode { get; }

    bool IsErrorPermanent { get; }

    ChatMessageStatus Status { get; }
  }
}
