// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.SecondaryTile
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.UI.StartScreen
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (ISecondaryTileFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Muse(Version = 100794368)]
  [Activatable(typeof (ISecondaryTileFactory2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ISecondaryTileStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SecondaryTile : ISecondaryTile, ISecondaryTile2
  {
    [MethodImpl]
    public extern SecondaryTile(
      string tileId,
      string displayName,
      string arguments,
      Uri square150x150Logo,
      TileSize desiredSize);

    [Deprecated("SecondaryTile(string, string, string, string, Windows.UI.StartScreen.TileOptions, Windows.Foundation.Uri) may be altered or unavailable for releases after Windows Phone 8.1. Instead, use SecondaryTile(string, string, string, Windows.Foundation.Uri, Windows.UI.StartScreen.TileSize).", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern SecondaryTile(
      string tileId,
      string shortName,
      string displayName,
      string arguments,
      TileOptions tileOptions,
      Uri logoReference);

    [Deprecated("SecondaryTile(string, string, string, string, Windows.UI.StartScreen.TileOptions, Windows.Foundation.Uri, Windows.Foundation.Uri) may be altered or unavailable for releases after Windows Phone 8.1. Instead, use SecondaryTile(string, string, string, Windows.Foundation.Uri, Windows.UI.StartScreen.TileSize).", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern SecondaryTile(
      string tileId,
      string shortName,
      string displayName,
      string arguments,
      TileOptions tileOptions,
      Uri logoReference,
      Uri wideLogoReference);

    [MethodImpl]
    public extern SecondaryTile(string tileId);

    [MethodImpl]
    public extern SecondaryTile();

    public extern string TileId { [MethodImpl] set; [MethodImpl] get; }

    public extern string Arguments { [MethodImpl] set; [MethodImpl] get; }

    public extern string ShortName { [Deprecated("ShortName may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayName.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; [Deprecated("ShortName may be altered or unavailable for releases after Windows 8.1. Instead, use DisplayName.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern string DisplayName { [MethodImpl] set; [MethodImpl] get; }

    public extern Uri Logo { [Deprecated("Logo may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.Square150x150Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; [Deprecated("Logo may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.Square150x150Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern Uri SmallLogo { [Deprecated("SmallLogo may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.Square30x30Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; [Deprecated("SmallLogo may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.Square30x30Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern Uri WideLogo { [Deprecated("WideLogo may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.Wide310x150Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; [Deprecated("WideLogo may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.Wide310x150Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern Uri LockScreenBadgeLogo { [MethodImpl] set; [MethodImpl] get; }

    public extern bool LockScreenDisplayBadgeAndTileText { [MethodImpl] set; [MethodImpl] get; }

    public extern TileOptions TileOptions { [Deprecated("TileOptions may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.ShowNameOnSquare150x150Logo, VisualElements.ShowNameOnWide310x150Logo, and RoamingEnabled.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; [Deprecated("TileOptions may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.ShowNameOnSquare150x150Logo, VisualElements.ShowNameOnWide310x150Logo, and RoamingEnabled.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern ForegroundText ForegroundText { [Deprecated("TileOptions may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.ShowNameOnSquare150x150Logo, VisualElements.ShowNameOnWide310x150Logo, and RoamingEnabled.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; [Deprecated("ForegroundText may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.ForegroundText.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern Color BackgroundColor { [Deprecated("BackgroundColor may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.BackgroundColor.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; [Deprecated("BackgroundColor may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.BackgroundColor.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    [Overload("RequestCreateAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestCreateAsync();

    [Overload("RequestCreateAsyncWithPoint")]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestCreateAsync(Point invocationPoint);

    [Overload("RequestCreateAsyncWithRect")]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestCreateForSelectionAsync(Rect selection);

    [Overload("RequestCreateAsyncWithRectAndPlacement")]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestCreateForSelectionAsync(
      Rect selection,
      Placement preferredPlacement);

    [Overload("RequestDeleteAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestDeleteAsync();

    [Overload("RequestDeleteAsyncWithPoint")]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestDeleteAsync(Point invocationPoint);

    [Overload("RequestDeleteAsyncWithRect")]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestDeleteForSelectionAsync(Rect selection);

    [Overload("RequestDeleteAsyncWithRectAndPlacement")]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestDeleteForSelectionAsync(
      Rect selection,
      Placement preferredPlacement);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> UpdateAsync();

    public extern string PhoneticName { [MethodImpl] set; [MethodImpl] get; }

    public extern SecondaryTileVisualElements VisualElements { [MethodImpl] get; }

    public extern bool RoamingEnabled { [MethodImpl] set; [MethodImpl] get; }

    public extern event TypedEventHandler<SecondaryTile, VisualElementsRequestedEventArgs> VisualElementsRequested;

    [MethodImpl]
    public static extern bool Exists(string tileId);

    [RemoteAsync]
    [Overload("FindAllAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<SecondaryTile>> FindAllAsync();

    [Overload("FindAllForApplicationAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<SecondaryTile>> FindAllAsync(
      string applicationId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<SecondaryTile>> FindAllForPackageAsync();
  }
}
