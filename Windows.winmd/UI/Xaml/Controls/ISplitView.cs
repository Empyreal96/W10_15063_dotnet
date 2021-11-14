// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISplitView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (SplitView))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2535599921, 14404, 17054, 147, 156, 22, 115, 21, 83, 34, 161)]
  [WebHostHidden]
  internal interface ISplitView
  {
    UIElement Content { get; set; }

    UIElement Pane { get; set; }

    bool IsPaneOpen { get; set; }

    double OpenPaneLength { get; set; }

    double CompactPaneLength { get; set; }

    SplitViewPanePlacement PanePlacement { get; set; }

    SplitViewDisplayMode DisplayMode { get; set; }

    SplitViewTemplateSettings TemplateSettings { get; }

    Brush PaneBackground { get; set; }

    event TypedEventHandler<SplitView, SplitViewPaneClosingEventArgs> PaneClosing;

    event TypedEventHandler<SplitView, object> PaneClosed;
  }
}
