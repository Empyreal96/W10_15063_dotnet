// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ToolTip
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Composable(typeof (IToolTipFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IToolTipStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class ToolTip : ContentControl, IToolTip
  {
    [MethodImpl]
    public extern ToolTip();

    public extern double HorizontalOffset { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsOpen { [MethodImpl] get; [MethodImpl] set; }

    public extern PlacementMode Placement { [MethodImpl] get; [MethodImpl] set; }

    public extern UIElement PlacementTarget { [MethodImpl] get; [MethodImpl] set; }

    public extern double VerticalOffset { [MethodImpl] get; [MethodImpl] set; }

    public extern ToolTipTemplateSettings TemplateSettings { [MethodImpl] get; }

    public extern event RoutedEventHandler Closed;

    public extern event RoutedEventHandler Opened;

    public static extern DependencyProperty HorizontalOffsetProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsOpenProperty { [MethodImpl] get; }

    public static extern DependencyProperty PlacementProperty { [MethodImpl] get; }

    public static extern DependencyProperty PlacementTargetProperty { [MethodImpl] get; }

    public static extern DependencyProperty VerticalOffsetProperty { [MethodImpl] get; }
  }
}
