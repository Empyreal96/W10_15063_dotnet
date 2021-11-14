// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.ISecondaryTile
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.UI.StartScreen
{
  [Guid(2661175776, 11189, 19392, 187, 141, 66, 178, 58, 188, 200, 141)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SecondaryTile))]
  internal interface ISecondaryTile
  {
    string TileId { set; get; }

    string Arguments { set; get; }

    string ShortName { [Deprecated("ShortName may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayName.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; [Deprecated("ShortName may be altered or unavailable for releases after Windows 8.1. Instead, use DisplayName.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    string DisplayName { set; get; }

    Uri Logo { [Deprecated("Logo may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.Square150x150Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; [Deprecated("Logo may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.Square150x150Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    Uri SmallLogo { [Deprecated("SmallLogo may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.Square30x30Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; [Deprecated("SmallLogo may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.Square30x30Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    Uri WideLogo { [Deprecated("WideLogo may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.Wide310x150Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; [Deprecated("WideLogo may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.Wide310x150Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    Uri LockScreenBadgeLogo { set; get; }

    bool LockScreenDisplayBadgeAndTileText { set; get; }

    TileOptions TileOptions { [Deprecated("TileOptions may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.ShowNameOnSquare150x150Logo, VisualElements.ShowNameOnWide310x150Logo, and RoamingEnabled.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; [Deprecated("TileOptions may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.ShowNameOnSquare150x150Logo, VisualElements.ShowNameOnWide310x150Logo, and RoamingEnabled.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    ForegroundText ForegroundText { [Deprecated("TileOptions may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.ShowNameOnSquare150x150Logo, VisualElements.ShowNameOnWide310x150Logo, and RoamingEnabled.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; [Deprecated("ForegroundText may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.ForegroundText.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    Color BackgroundColor { [Deprecated("BackgroundColor may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.BackgroundColor.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; [Deprecated("BackgroundColor may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.BackgroundColor.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    [Overload("RequestCreateAsync")]
    IAsyncOperation<bool> RequestCreateAsync();

    [Overload("RequestCreateAsyncWithPoint")]
    IAsyncOperation<bool> RequestCreateAsync(Point invocationPoint);

    [Overload("RequestCreateAsyncWithRect")]
    IAsyncOperation<bool> RequestCreateForSelectionAsync(Rect selection);

    [Overload("RequestCreateAsyncWithRectAndPlacement")]
    IAsyncOperation<bool> RequestCreateForSelectionAsync(
      Rect selection,
      Placement preferredPlacement);

    [Overload("RequestDeleteAsync")]
    IAsyncOperation<bool> RequestDeleteAsync();

    [Overload("RequestDeleteAsyncWithPoint")]
    IAsyncOperation<bool> RequestDeleteAsync(Point invocationPoint);

    [Overload("RequestDeleteAsyncWithRect")]
    IAsyncOperation<bool> RequestDeleteForSelectionAsync(Rect selection);

    [Overload("RequestDeleteAsyncWithRectAndPlacement")]
    IAsyncOperation<bool> RequestDeleteForSelectionAsync(
      Rect selection,
      Placement preferredPlacement);

    [RemoteAsync]
    IAsyncOperation<bool> UpdateAsync();
  }
}
