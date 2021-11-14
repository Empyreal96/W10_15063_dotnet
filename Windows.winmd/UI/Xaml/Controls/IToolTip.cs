// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IToolTip
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(2112214879, 17429, 17055, 181, 35, 105, 155, 219, 140, 48, 219)]
  [ExclusiveTo(typeof (ToolTip))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IToolTip
  {
    double HorizontalOffset { get; set; }

    bool IsOpen { get; set; }

    PlacementMode Placement { get; set; }

    UIElement PlacementTarget { get; set; }

    double VerticalOffset { get; set; }

    ToolTipTemplateSettings TemplateSettings { get; }

    event RoutedEventHandler Closed;

    event RoutedEventHandler Opened;
  }
}
