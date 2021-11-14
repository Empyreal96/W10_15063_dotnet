// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IBadgeNotification
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BadgeNotification))]
  [Guid(123516106, 53386, 20015, 146, 51, 126, 40, 156, 31, 119, 34)]
  internal interface IBadgeNotification
  {
    XmlDocument Content { get; }

    IReference<DateTime> ExpirationTime { set; get; }
  }
}
