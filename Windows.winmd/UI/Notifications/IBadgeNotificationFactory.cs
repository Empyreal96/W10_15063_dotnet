// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IBadgeNotificationFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (BadgeNotification))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3992081870, 1560, 19801, 148, 138, 90, 97, 4, 12, 82, 249)]
  internal interface IBadgeNotificationFactory
  {
    BadgeNotification CreateBadgeNotification(XmlDocument content);
  }
}
