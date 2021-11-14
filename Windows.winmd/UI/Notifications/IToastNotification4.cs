// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotification4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(353716533, 10474, 18215, 136, 233, 197, 134, 128, 226, 209, 24)]
  [ExclusiveTo(typeof (ToastNotification))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IToastNotification4
  {
    NotificationData Data { get; set; }

    ToastNotificationPriority Priority { get; set; }
  }
}
