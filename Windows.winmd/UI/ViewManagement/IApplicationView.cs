// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ApplicationView))]
  [Guid(3525498137, 17249, 17694, 150, 196, 96, 244, 249, 116, 45, 176)]
  internal interface IApplicationView
  {
    ApplicationViewOrientation Orientation { get; }

    bool AdjacentToLeftDisplayEdge { get; }

    bool AdjacentToRightDisplayEdge { get; }

    bool IsFullScreen { [Deprecated("To check full screen mode, use IsFullScreenMode. To check if the view is adjacent to both edges, use AdjacentToLeftDisplayEdge and AdjacentToRightDisplayEdge. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    bool IsOnLockScreen { get; }

    bool IsScreenCaptureEnabled { get; set; }

    string Title { set; get; }

    int Id { get; }

    event TypedEventHandler<ApplicationView, ApplicationViewConsolidatedEventArgs> Consolidated;
  }
}
