// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.ISecondaryTileVisualElements
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SecondaryTileVisualElements))]
  [Guid(495842099, 33118, 16703, 159, 80, 168, 29, 167, 10, 150, 178)]
  internal interface ISecondaryTileVisualElements
  {
    Uri Square30x30Logo { [Deprecated("SecondaryTileVisualElements.Square30x30Logo may be altered or unavailable for release after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; [Deprecated("SecondaryTileVisualElements.Square30x30Logo may be altered or unavailable for release after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    Uri Square70x70Logo { [Deprecated("SecondaryTileVisualElements.Square70x70Logo may be altered or unavailable for release after Windows Phone 8.1.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; [Deprecated("SecondaryTileVisualElements.Square70x70Logo may be altered or unavailable for release after Windows Phone 8.1.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    Uri Square150x150Logo { set; get; }

    Uri Wide310x150Logo { set; get; }

    Uri Square310x310Logo { set; get; }

    ForegroundText ForegroundText { set; get; }

    Color BackgroundColor { set; get; }

    bool ShowNameOnSquare150x150Logo { set; get; }

    bool ShowNameOnWide310x150Logo { set; get; }

    bool ShowNameOnSquare310x310Logo { set; get; }
  }
}
