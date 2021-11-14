// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageNotificationTriggerDetails2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ChatMessageNotificationTriggerDetails))]
  [Guid(1807033056, 43527, 20433, 148, 113, 119, 147, 79, 183, 94, 230)]
  internal interface IChatMessageNotificationTriggerDetails2 : IChatMessageNotificationTriggerDetails
  {
    bool ShouldDisplayToast { get; }

    bool ShouldUpdateDetailText { get; }

    bool ShouldUpdateBadge { get; }

    bool ShouldUpdateActionCenter { get; }
  }
}
