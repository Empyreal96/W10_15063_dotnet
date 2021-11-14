// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.ApplicationView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.ViewManagement
{
  [Threading(ThreadingModel.Both)]
  [Muse(Version = 100794368)]
  [Static(typeof (IApplicationViewStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IApplicationViewStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IApplicationViewFullscreenStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IApplicationViewInteropStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IApplicationViewStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ApplicationView : 
    IApplicationView,
    IApplicationView2,
    IApplicationView3,
    IApplicationView4
  {
    public extern ApplicationViewOrientation Orientation { [MethodImpl] get; }

    public extern bool AdjacentToLeftDisplayEdge { [MethodImpl] get; }

    public extern bool AdjacentToRightDisplayEdge { [MethodImpl] get; }

    public extern bool IsFullScreen { [Deprecated("To check full screen mode, use IsFullScreenMode. To check if the view is adjacent to both edges, use AdjacentToLeftDisplayEdge and AdjacentToRightDisplayEdge. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern bool IsOnLockScreen { [MethodImpl] get; }

    public extern bool IsScreenCaptureEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern string Title { [MethodImpl] set; [MethodImpl] get; }

    public extern int Id { [MethodImpl] get; }

    public extern event TypedEventHandler<ApplicationView, ApplicationViewConsolidatedEventArgs> Consolidated;

    public extern bool SuppressSystemOverlays { [Deprecated("Use the TryEnterFullScreen method and IsFullScreenMode property instead of SuppressSystemOverlays. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("Use the TryEnterFullScreen method and IsFullScreenMode property instead of SuppressSystemOverlays. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    public extern Rect VisibleBounds { [MethodImpl] get; }

    public extern event TypedEventHandler<ApplicationView, object> VisibleBoundsChanged;

    [MethodImpl]
    public extern bool SetDesiredBoundsMode(ApplicationViewBoundsMode boundsMode);

    public extern ApplicationViewBoundsMode DesiredBoundsMode { [MethodImpl] get; }

    public extern ApplicationViewTitleBar TitleBar { [MethodImpl] get; }

    public extern FullScreenSystemOverlayMode FullScreenSystemOverlayMode { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsFullScreenMode { [MethodImpl] get; }

    [MethodImpl]
    public extern bool TryEnterFullScreenMode();

    [MethodImpl]
    public extern void ExitFullScreenMode();

    [MethodImpl]
    public extern void ShowStandardSystemOverlays();

    [MethodImpl]
    public extern bool TryResizeView(Size value);

    [MethodImpl]
    public extern void SetPreferredMinSize(Size minSize);

    public extern ApplicationViewMode ViewMode { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IsViewModeSupported(ApplicationViewMode viewMode);

    [Overload("TryEnterViewModeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryEnterViewModeAsync(
      ApplicationViewMode viewMode);

    [Overload("TryEnterViewModeWithPreferencesAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryEnterViewModeAsync(
      ApplicationViewMode viewMode,
      ViewModePreferences viewModePreferences);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryConsolidateAsync();

    public static extern ApplicationViewWindowingMode PreferredLaunchWindowingMode { [MethodImpl] get; [MethodImpl] set; }

    public static extern Size PreferredLaunchViewSize { [MethodImpl] get; [MethodImpl] set; }

    [Deprecated("IApplicationViewFullscreenStatics is deprecated after Windows 8. Please use other resize APIs.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern bool TryUnsnapToFullscreen();

    [MethodImpl]
    public static extern int GetApplicationViewIdForWindow(ICoreWindow window);

    [MethodImpl]
    public static extern ApplicationView GetForCurrentView();

    public static extern bool TerminateAppOnFinalViewClose { [MethodImpl] get; [MethodImpl] set; }

    public static extern ApplicationViewState Value { [Deprecated("Value may be altered or unavailable for releases after Windows 8.1. Instead, query for window layout sizes directly.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    [Deprecated("TryUnsnap may be altered or unavailable for releases after Windows 8.1. Apps can be continuously resized, but cannot be snapped, starting in Windows 8.1.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern bool TryUnsnap();
  }
}
