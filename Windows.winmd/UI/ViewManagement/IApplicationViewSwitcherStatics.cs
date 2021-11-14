// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewSwitcherStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [Guid(2539597598, 58966, 19550, 160, 161, 113, 124, 111, 250, 125, 100)]
  [ExclusiveTo(typeof (ApplicationViewSwitcher))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IApplicationViewSwitcherStatics
  {
    void DisableShowingMainViewOnActivation();

    [Overload("TryShowAsStandaloneAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> TryShowAsStandaloneAsync(int viewId);

    [Overload("TryShowAsStandaloneWithSizePreferenceAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> TryShowAsStandaloneAsync(
      int viewId,
      ViewSizePreference sizePreference);

    [RemoteAsync]
    [Overload("TryShowAsStandaloneWithAnchorViewAndSizePreferenceAsync")]
    IAsyncOperation<bool> TryShowAsStandaloneAsync(
      int viewId,
      ViewSizePreference sizePreference,
      int anchorViewId,
      ViewSizePreference anchorSizePreference);

    [RemoteAsync]
    [Overload("SwitchAsync")]
    IAsyncAction SwitchAsync(int viewId);

    [Overload("SwitchFromViewAsync")]
    [RemoteAsync]
    IAsyncAction SwitchAsync(int toViewId, int fromViewId);

    [Overload("SwitchFromViewWithOptionsAsync")]
    [RemoteAsync]
    IAsyncAction SwitchAsync(
      int toViewId,
      int fromViewId,
      ApplicationViewSwitchingOptions options);

    [RemoteAsync]
    IAsyncOperation<bool> PrepareForCustomAnimatedSwitchAsync(
      int toViewId,
      int fromViewId,
      ApplicationViewSwitchingOptions options);
  }
}
