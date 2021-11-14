// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationView4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (ApplicationView))]
  [Guid(367381484, 40463, 18101, 188, 63, 155, 246, 83, 231, 75, 94)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IApplicationView4
  {
    ApplicationViewMode ViewMode { get; }

    bool IsViewModeSupported(ApplicationViewMode viewMode);

    [Overload("TryEnterViewModeAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> TryEnterViewModeAsync(ApplicationViewMode viewMode);

    [RemoteAsync]
    [Overload("TryEnterViewModeWithPreferencesAsync")]
    IAsyncOperation<bool> TryEnterViewModeAsync(
      ApplicationViewMode viewMode,
      ViewModePreferences viewModePreferences);

    [RemoteAsync]
    IAsyncOperation<bool> TryConsolidateAsync();
  }
}
