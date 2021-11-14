// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IScheduledTileNotificationFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(864228234, 39104, 19515, 187, 214, 74, 99, 60, 124, 252, 41)]
  [ExclusiveTo(typeof (ScheduledTileNotification))]
  internal interface IScheduledTileNotificationFactory
  {
    ScheduledTileNotification CreateScheduledTileNotification(
      XmlDocument content,
      DateTime deliveryTime);
  }
}
