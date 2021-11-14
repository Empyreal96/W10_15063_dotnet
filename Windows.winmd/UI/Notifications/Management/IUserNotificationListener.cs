// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.Management.IUserNotificationListener
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications.Management
{
  [Guid(1649753665, 35334, 19695, 130, 21, 96, 51, 165, 190, 75, 3)]
  [ExclusiveTo(typeof (UserNotificationListener))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IUserNotificationListener
  {
    [RemoteAsync]
    IAsyncOperation<UserNotificationListenerAccessStatus> RequestAccessAsync();

    UserNotificationListenerAccessStatus GetAccessStatus();

    event TypedEventHandler<UserNotificationListener, UserNotificationChangedEventArgs> NotificationChanged;

    [RemoteAsync]
    IAsyncOperation<IVectorView<UserNotification>> GetNotificationsAsync(
      NotificationKinds kinds);

    UserNotification GetNotification(uint notificationId);

    void ClearNotifications();

    void RemoveNotification(uint notificationId);
  }
}
