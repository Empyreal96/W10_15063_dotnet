// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatRecipientDeliveryInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ChatRecipientDeliveryInfo : IChatRecipientDeliveryInfo
  {
    [MethodImpl]
    public extern ChatRecipientDeliveryInfo();

    public extern string TransportAddress { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<DateTime> DeliveryTime { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<DateTime> ReadTime { [MethodImpl] get; [MethodImpl] set; }

    public extern ChatTransportErrorCodeCategory TransportErrorCodeCategory { [MethodImpl] get; }

    public extern ChatTransportInterpretedErrorCode TransportInterpretedErrorCode { [MethodImpl] get; }

    public extern int TransportErrorCode { [MethodImpl] get; }

    public extern bool IsErrorPermanent { [MethodImpl] get; }

    public extern ChatMessageStatus Status { [MethodImpl] get; }
  }
}
