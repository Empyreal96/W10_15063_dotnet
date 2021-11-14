// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IScheduledToastNotification2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ScheduledToastNotification))]
  [Guid(2792267932, 12724, 17328, 181, 221, 122, 64, 232, 83, 99, 177)]
  internal interface IScheduledToastNotification2
  {
    string Tag { set; get; }

    string Group { set; get; }

    bool SuppressPopup { set; get; }
  }
}
