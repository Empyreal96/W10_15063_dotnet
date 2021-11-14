// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.IPushNotificationReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Notifications;

namespace Windows.Networking.PushNotifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3506855436, 14029, 18508, 185, 53, 10, 153, 183, 83, 207, 0)]
  [ExclusiveTo(typeof (PushNotificationReceivedEventArgs))]
  internal interface IPushNotificationReceivedEventArgs
  {
    bool Cancel { set; get; }

    PushNotificationType NotificationType { get; }

    ToastNotification ToastNotification { get; }

    TileNotification TileNotification { get; }

    BadgeNotification BadgeNotification { get; }

    RawNotification RawNotification { get; }
  }
}
