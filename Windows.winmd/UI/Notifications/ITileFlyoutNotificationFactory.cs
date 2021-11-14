// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ITileFlyoutNotificationFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(4015353845, 21030, 20267, 178, 120, 136, 163, 93, 254, 86, 159)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TileFlyoutNotification))]
  internal interface ITileFlyoutNotificationFactory
  {
    TileFlyoutNotification CreateTileFlyoutNotification(XmlDocument content);
  }
}
