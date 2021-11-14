// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotificationHistoryChangedTriggerDetail2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (ToastNotificationHistoryChangedTriggerDetail))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(188148098, 51313, 18939, 186, 187, 37, 189, 188, 76, 196, 91)]
  internal interface IToastNotificationHistoryChangedTriggerDetail2
  {
    string CollectionId { get; }
  }
}
