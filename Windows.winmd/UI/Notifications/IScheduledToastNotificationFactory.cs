// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IScheduledToastNotificationFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(3888042385, 3001, 16777, 131, 148, 49, 118, 27, 71, 111, 215)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ScheduledToastNotification))]
  internal interface IScheduledToastNotificationFactory
  {
    ScheduledToastNotification CreateScheduledToastNotification(
      XmlDocument content,
      DateTime deliveryTime);

    ScheduledToastNotification CreateScheduledToastNotificationRecurring(
      XmlDocument content,
      DateTime deliveryTime,
      TimeSpan snoozeInterval,
      uint maximumSnoozeCount);
  }
}
