// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotifier
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (ToastNotifier))]
  [Guid(1972534163, 1011, 16876, 145, 211, 110, 91, 172, 27, 56, 231)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IToastNotifier
  {
    void Show(ToastNotification notification);

    void Hide(ToastNotification notification);

    NotificationSetting Setting { get; }

    void AddToSchedule(ScheduledToastNotification scheduledToast);

    void RemoveFromSchedule(ScheduledToastNotification scheduledToast);

    IVectorView<ScheduledToastNotification> GetScheduledToastNotifications();
  }
}
