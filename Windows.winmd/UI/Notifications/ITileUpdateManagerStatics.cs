// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ITileUpdateManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3658849885, 16041, 18822, 141, 132, 176, 157, 94, 18, 39, 109)]
  [ExclusiveTo(typeof (TileUpdateManager))]
  internal interface ITileUpdateManagerStatics
  {
    [Overload("CreateTileUpdaterForApplication")]
    TileUpdater CreateTileUpdaterForApplication();

    [Overload("CreateTileUpdaterForApplicationWithId")]
    TileUpdater CreateTileUpdaterForApplication(string applicationId);

    TileUpdater CreateTileUpdaterForSecondaryTile(string tileId);

    XmlDocument GetTemplateContent(TileTemplateType type);
  }
}
