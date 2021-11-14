// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.TileSize
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TileSize
  {
    Default,
    [Deprecated("TileSize.Square30x30 may be altered or unavailable for release after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] Square30x30,
    [Deprecated("TileSize.Square70x70 may be altered or unavailable for release after Windows Phone 8.1.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] Square70x70,
    Square150x150,
    Wide310x150,
    Square310x310,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Square71x71,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Square44x44,
  }
}
