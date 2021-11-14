// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IBadgeUpdateManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (BadgeUpdateManager))]
  [Guid(859836330, 28117, 16645, 174, 188, 155, 80, 252, 164, 146, 218)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBadgeUpdateManagerStatics
  {
    [Overload("CreateBadgeUpdaterForApplication")]
    BadgeUpdater CreateBadgeUpdaterForApplication();

    [Overload("CreateBadgeUpdaterForApplicationWithId")]
    BadgeUpdater CreateBadgeUpdaterForApplication(string applicationId);

    BadgeUpdater CreateBadgeUpdaterForSecondaryTile(string tileId);

    XmlDocument GetTemplateContent(BadgeTemplateType type);
  }
}
