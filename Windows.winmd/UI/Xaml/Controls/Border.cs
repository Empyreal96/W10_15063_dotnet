// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Border
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [ContentProperty(Name = "Child")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IBorderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Border : FrameworkElement, IBorder
  {
    [MethodImpl]
    public extern Border();

    public extern Brush BorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness BorderThickness { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush Background { [MethodImpl] get; [MethodImpl] set; }

    public extern CornerRadius CornerRadius { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness Padding { [MethodImpl] get; [MethodImpl] set; }

    public extern UIElement Child { [MethodImpl] get; [MethodImpl] set; }

    public extern TransitionCollection ChildTransitions { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty BorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty BorderThicknessProperty { [MethodImpl] get; }

    public static extern DependencyProperty BackgroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty CornerRadiusProperty { [MethodImpl] get; }

    public static extern DependencyProperty PaddingProperty { [MethodImpl] get; }

    public static extern DependencyProperty ChildTransitionsProperty { [MethodImpl] get; }
  }
}
