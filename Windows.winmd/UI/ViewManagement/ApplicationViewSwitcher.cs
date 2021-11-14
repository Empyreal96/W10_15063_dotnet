// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.ApplicationViewSwitcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IApplicationViewSwitcherStatics3), 262144, "Windows.Foundation.UniversalApiContract")]
  [Muse(Version = 100859904)]
  [Static(typeof (IApplicationViewSwitcherStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IApplicationViewSwitcherStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class ApplicationViewSwitcher
  {
    [RemoteAsync]
    [Overload("TryShowAsViewModeAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> TryShowAsViewModeAsync(
      int viewId,
      ApplicationViewMode viewMode);

    [Overload("TryShowAsViewModeWithPreferencesAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> TryShowAsViewModeAsync(
      int viewId,
      ApplicationViewMode viewMode,
      ViewModePreferences viewModePreferences);

    [MethodImpl]
    public static extern void DisableSystemViewActivationPolicy();

    [MethodImpl]
    public static extern void DisableShowingMainViewOnActivation();

    [Overload("TryShowAsStandaloneAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> TryShowAsStandaloneAsync(int viewId);

    [Overload("TryShowAsStandaloneWithSizePreferenceAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> TryShowAsStandaloneAsync(
      int viewId,
      ViewSizePreference sizePreference);

    [RemoteAsync]
    [Overload("TryShowAsStandaloneWithAnchorViewAndSizePreferenceAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> TryShowAsStandaloneAsync(
      int viewId,
      ViewSizePreference sizePreference,
      int anchorViewId,
      ViewSizePreference anchorSizePreference);

    [Overload("SwitchAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction SwitchAsync(int viewId);

    [Overload("SwitchFromViewAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction SwitchAsync(int toViewId, int fromViewId);

    [RemoteAsync]
    [Overload("SwitchFromViewWithOptionsAsync")]
    [MethodImpl]
    public static extern IAsyncAction SwitchAsync(
      int toViewId,
      int fromViewId,
      ApplicationViewSwitchingOptions options);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> PrepareForCustomAnimatedSwitchAsync(
      int toViewId,
      int fromViewId,
      ApplicationViewSwitchingOptions options);
  }
}
