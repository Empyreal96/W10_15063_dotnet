// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ITileNotificationFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(3333152110, 18728, 18120, 189, 191, 129, 160, 71, 222, 160, 212)]
  [ExclusiveTo(typeof (TileNotification))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITileNotificationFactory
  {
    TileNotification CreateTileNotification(XmlDocument content);
  }
}
