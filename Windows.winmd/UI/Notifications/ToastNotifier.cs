// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ToastNotifier
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ToastNotifier : IToastNotifier, IToastNotifier2
  {
    [MethodImpl]
    public extern void Show(ToastNotification notification);

    [MethodImpl]
    public extern void Hide(ToastNotification notification);

    public extern NotificationSetting Setting { [MethodImpl] get; }

    [MethodImpl]
    public extern void AddToSchedule(ScheduledToastNotification scheduledToast);

    [MethodImpl]
    public extern void RemoveFromSchedule(ScheduledToastNotification scheduledToast);

    [MethodImpl]
    public extern IVectorView<ScheduledToastNotification> GetScheduledToastNotifications();

    [Overload("UpdateWithTagAndGroup")]
    [MethodImpl]
    public extern NotificationUpdateResult Update(
      NotificationData data,
      string tag,
      string group);

    [Overload("UpdateWithTag")]
    [MethodImpl]
    public extern NotificationUpdateResult Update(
      NotificationData data,
      string tag);
  }
}
