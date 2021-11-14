// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.ISecondaryTileFactory2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [Guid(659262011, 21037, 17550, 158, 178, 208, 103, 42, 179, 69, 200)]
  [ExclusiveTo(typeof (SecondaryTile))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISecondaryTileFactory2 : ISecondaryTileFactory
  {
    SecondaryTile CreateMinimalTile(
      string tileId,
      string displayName,
      string arguments,
      Uri square150x150Logo,
      TileSize desiredSize);
  }
}
