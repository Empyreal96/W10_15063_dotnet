// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IUserNotificationChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (UserNotificationChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3065866297, 31183, 19237, 130, 192, 12, 225, 238, 248, 31, 140)]
  internal interface IUserNotificationChangedEventArgs
  {
    UserNotificationChangedKind ChangeKind { get; }

    uint UserNotificationId { get; }
  }
}
