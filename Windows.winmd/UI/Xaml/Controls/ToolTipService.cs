// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ToolTipService
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [Static(typeof (IToolTipServiceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ToolTipService : IToolTipService
  {
    public static extern DependencyProperty PlacementProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern PlacementMode GetPlacement(DependencyObject element);

    [MethodImpl]
    public static extern void SetPlacement(DependencyObject element, PlacementMode value);

    public static extern DependencyProperty PlacementTargetProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern UIElement GetPlacementTarget(DependencyObject element);

    [MethodImpl]
    public static extern void SetPlacementTarget(DependencyObject element, UIElement value);

    public static extern DependencyProperty ToolTipProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern object GetToolTip(DependencyObject element);

    [MethodImpl]
    public static extern void SetToolTip(DependencyObject element, object value);
  }
}
