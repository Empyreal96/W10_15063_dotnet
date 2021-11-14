// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatConversationThreadingInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(857481692, 31239, 17442, 163, 44, 36, 190, 124, 109, 171, 36)]
  [ExclusiveTo(typeof (ChatConversationThreadingInfo))]
  internal interface IChatConversationThreadingInfo
  {
    string ContactId { get; set; }

    string Custom { get; set; }

    string ConversationId { get; set; }

    IVector<string> Participants { get; }

    ChatConversationThreadingKind Kind { get; set; }
  }
}
