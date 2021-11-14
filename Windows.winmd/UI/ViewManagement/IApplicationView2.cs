// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationView2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (ApplicationView))]
  [Guid(3900092822, 42309, 16604, 181, 148, 69, 12, 186, 104, 204, 0)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IApplicationView2
  {
    bool SuppressSystemOverlays { [Deprecated("Use the TryEnterFullScreen method and IsFullScreenMode property instead of SuppressSystemOverlays. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("Use the TryEnterFullScreen method and IsFullScreenMode property instead of SuppressSystemOverlays. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; }

    Rect VisibleBounds { get; }

    event TypedEventHandler<ApplicationView, object> VisibleBoundsChanged;

    bool SetDesiredBoundsMode(ApplicationViewBoundsMode boundsMode);

    ApplicationViewBoundsMode DesiredBoundsMode { get; }
  }
}
