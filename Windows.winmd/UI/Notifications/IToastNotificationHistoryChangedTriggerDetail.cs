// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotificationHistoryChangedTriggerDetail
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(3674439674, 104, 16684, 156, 131, 38, 124, 55, 246, 86, 112)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ToastNotificationHistoryChangedTriggerDetail))]
  internal interface IToastNotificationHistoryChangedTriggerDetail
  {
    ToastHistoryChangedType ChangeType { get; }
  }
}
