// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IToolTipServiceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ToolTipService))]
  [Guid(2263239160, 57925, 18602, 168, 200, 209, 7, 62, 215, 99, 25)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IToolTipServiceStatics
  {
    DependencyProperty PlacementProperty { get; }

    PlacementMode GetPlacement(DependencyObject element);

    void SetPlacement(DependencyObject element, PlacementMode value);

    DependencyProperty PlacementTargetProperty { get; }

    UIElement GetPlacementTarget(DependencyObject element);

    void SetPlacementTarget(DependencyObject element, UIElement value);

    DependencyProperty ToolTipProperty { get; }

    object GetToolTip(DependencyObject element);

    void SetToolTip(DependencyObject element, object value);
  }
}
