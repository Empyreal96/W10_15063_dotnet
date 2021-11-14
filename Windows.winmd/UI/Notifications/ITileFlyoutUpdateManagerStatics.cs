// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ITileFlyoutUpdateManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TileFlyoutUpdateManager))]
  [Guid(70662923, 6848, 19353, 136, 231, 173, 168, 62, 149, 61, 72)]
  internal interface ITileFlyoutUpdateManagerStatics
  {
    [Overload("CreateTileFlyoutUpdaterForApplication")]
    TileFlyoutUpdater CreateTileFlyoutUpdaterForApplication();

    [Overload("CreateTileFlyoutUpdaterForApplicationWithId")]
    TileFlyoutUpdater CreateTileFlyoutUpdaterForApplication(string applicationId);

    TileFlyoutUpdater CreateTileFlyoutUpdaterForSecondaryTile(string tileId);

    XmlDocument GetTemplateContent(TileFlyoutTemplateType type);
  }
}
