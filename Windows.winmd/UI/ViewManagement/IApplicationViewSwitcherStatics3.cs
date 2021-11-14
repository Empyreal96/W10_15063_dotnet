// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewSwitcherStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [Guid(2449839136, 32935, 18541, 178, 31, 199, 164, 162, 66, 163, 131)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (ApplicationViewSwitcher))]
  internal interface IApplicationViewSwitcherStatics3
  {
    [Overload("TryShowAsViewModeAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> TryShowAsViewModeAsync(
      int viewId,
      ApplicationViewMode viewMode);

    [Overload("TryShowAsViewModeWithPreferencesAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> TryShowAsViewModeAsync(
      int viewId,
      ApplicationViewMode viewMode,
      ViewModePreferences viewModePreferences);
  }
}
