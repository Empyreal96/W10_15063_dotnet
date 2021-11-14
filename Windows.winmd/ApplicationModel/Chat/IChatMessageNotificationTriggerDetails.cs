// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageNotificationTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (ChatMessageNotificationTriggerDetails))]
  [Guid(4248063483, 12387, 19991, 133, 134, 198, 192, 130, 98, 230, 192)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IChatMessageNotificationTriggerDetails
  {
    ChatMessage ChatMessage { get; }
  }
}
