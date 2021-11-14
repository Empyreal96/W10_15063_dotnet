// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IUserNotificationChangedTriggerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Notifications;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (UserNotificationChangedTrigger))]
  [Guid(3402908524, 27051, 19992, 164, 138, 94, 210, 172, 67, 89, 87)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IUserNotificationChangedTriggerFactory
  {
    UserNotificationChangedTrigger Create(
      NotificationKinds notificationKinds);
  }
}
