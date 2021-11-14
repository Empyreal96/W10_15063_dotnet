// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.UserNotificationChangedTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Notifications;

namespace Windows.ApplicationModel.Background
{
  [Activatable(typeof (IUserNotificationChangedTriggerFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.MTA)]
  public sealed class UserNotificationChangedTrigger : IBackgroundTrigger
  {
    [MethodImpl]
    public extern UserNotificationChangedTrigger(NotificationKinds notificationKinds);
  }
}
