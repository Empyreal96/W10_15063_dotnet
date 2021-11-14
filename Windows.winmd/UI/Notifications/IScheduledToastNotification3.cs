// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IScheduledToastNotification3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (ScheduledToastNotification))]
  [Guid(2554502795, 48434, 19003, 157, 21, 34, 174, 164, 148, 98, 161)]
  internal interface IScheduledToastNotification3
  {
    NotificationMirroring NotificationMirroring { get; set; }

    string RemoteId { get; set; }
  }
}
