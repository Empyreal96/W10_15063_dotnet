// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IScheduledToastNotification
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (ScheduledToastNotification))]
  [Guid(2046130168, 3559, 18637, 151, 64, 155, 55, 4, 144, 200, 56)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IScheduledToastNotification
  {
    XmlDocument Content { get; }

    DateTime DeliveryTime { get; }

    IReference<TimeSpan> SnoozeInterval { get; }

    uint MaximumSnoozeCount { get; }

    string Id { set; get; }
  }
}
