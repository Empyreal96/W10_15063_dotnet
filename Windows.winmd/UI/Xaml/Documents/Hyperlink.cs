// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.Hyperlink
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Documents
{
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Static(typeof (IHyperlinkStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IHyperlinkStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IHyperlinkStatics4), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IHyperlinkStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class Hyperlink : Span, IHyperlink, IHyperlink2, IHyperlink3, IHyperlink4
  {
    [MethodImpl]
    public extern Hyperlink();

    public extern Uri NavigateUri { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<Hyperlink, HyperlinkClickEventArgs> Click;

    public extern UnderlineStyle UnderlineStyle { [MethodImpl] get; [MethodImpl] set; }

    public extern DependencyObject XYFocusLeft { [MethodImpl] get; [MethodImpl] set; }

    public extern DependencyObject XYFocusRight { [MethodImpl] get; [MethodImpl] set; }

    public extern DependencyObject XYFocusUp { [MethodImpl] get; [MethodImpl] set; }

    public extern DependencyObject XYFocusDown { [MethodImpl] get; [MethodImpl] set; }

    public extern ElementSoundMode ElementSoundMode { [MethodImpl] get; [MethodImpl] set; }

    public extern FocusState FocusState { [MethodImpl] get; }

    public extern XYFocusNavigationStrategy XYFocusUpNavigationStrategy { [MethodImpl] get; [MethodImpl] set; }

    public extern XYFocusNavigationStrategy XYFocusDownNavigationStrategy { [MethodImpl] get; [MethodImpl] set; }

    public extern XYFocusNavigationStrategy XYFocusLeftNavigationStrategy { [MethodImpl] get; [MethodImpl] set; }

    public extern XYFocusNavigationStrategy XYFocusRightNavigationStrategy { [MethodImpl] get; [MethodImpl] set; }

    public extern event RoutedEventHandler GotFocus;

    public extern event RoutedEventHandler LostFocus;

    [MethodImpl]
    public extern bool Focus(FocusState value);

    public static extern DependencyProperty FocusStateProperty { [MethodImpl] get; }

    public static extern DependencyProperty XYFocusUpNavigationStrategyProperty { [MethodImpl] get; }

    public static extern DependencyProperty XYFocusDownNavigationStrategyProperty { [MethodImpl] get; }

    public static extern DependencyProperty XYFocusLeftNavigationStrategyProperty { [MethodImpl] get; }

    public static extern DependencyProperty XYFocusRightNavigationStrategyProperty { [MethodImpl] get; }

    public static extern DependencyProperty XYFocusLeftProperty { [MethodImpl] get; }

    public static extern DependencyProperty XYFocusRightProperty { [MethodImpl] get; }

    public static extern DependencyProperty XYFocusUpProperty { [MethodImpl] get; }

    public static extern DependencyProperty XYFocusDownProperty { [MethodImpl] get; }

    public static extern DependencyProperty ElementSoundModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty UnderlineStyleProperty { [MethodImpl] get; }

    public static extern DependencyProperty NavigateUriProperty { [MethodImpl] get; }
  }
}
