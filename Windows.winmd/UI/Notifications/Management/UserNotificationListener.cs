// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.Management.UserNotificationListener
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications.Management
{
  [Muse(Version = 167772160)]
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (IUserNotificationListenerStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class UserNotificationListener : IUserNotificationListener
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UserNotificationListenerAccessStatus> RequestAccessAsync();

    [MethodImpl]
    public extern UserNotificationListenerAccessStatus GetAccessStatus();

    public extern event TypedEventHandler<UserNotificationListener, UserNotificationChangedEventArgs> NotificationChanged;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<UserNotification>> GetNotificationsAsync(
      NotificationKinds kinds);

    [MethodImpl]
    public extern UserNotification GetNotification(uint notificationId);

    [MethodImpl]
    public extern void ClearNotifications();

    [MethodImpl]
    public extern void RemoveNotification(uint notificationId);

    public static extern UserNotificationListener Current { [MethodImpl] get; }
  }
}
