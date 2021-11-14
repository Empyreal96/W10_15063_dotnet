// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.ISecondaryTileFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [Guid(1475685536, 20924, 19135, 142, 191, 98, 122, 3, 152, 176, 90)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SecondaryTile))]
  internal interface ISecondaryTileFactory
  {
    [Deprecated("SecondaryTile(string, string, string, string, Windows.UI.StartScreen.TileOptions, Windows.Foundation.Uri) may be altered or unavailable for releases after Windows Phone 8.1. Instead, use SecondaryTile(string, string, string, Windows.Foundation.Uri, Windows.UI.StartScreen.TileSize).", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    SecondaryTile CreateTile(
      string tileId,
      string shortName,
      string displayName,
      string arguments,
      TileOptions tileOptions,
      Uri logoReference);

    [Deprecated("SecondaryTile(string, string, string, string, Windows.UI.StartScreen.TileOptions, Windows.Foundation.Uri, Windows.Foundation.Uri) may be altered or unavailable for releases after Windows Phone 8.1. Instead, use SecondaryTile(string, string, string, Windows.Foundation.Uri, Windows.UI.StartScreen.TileSize).", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    SecondaryTile CreateWideTile(
      string tileId,
      string shortName,
      string displayName,
      string arguments,
      TileOptions tileOptions,
      Uri logoReference,
      Uri wideLogoReference);

    SecondaryTile CreateWithId(string tileId);
  }
}
