// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.TextElement
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Documents
{
  [Static(typeof (ITextElementStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Static(typeof (ITextElementStatics4), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ITextElementStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ITextElementStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (ITextElementFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public class TextElement : 
    DependencyObject,
    ITextElement,
    ITextElementOverrides,
    ITextElement2,
    ITextElement3,
    ITextElement4
  {
    public extern string Name { [MethodImpl] get; }

    public extern double FontSize { [MethodImpl] get; [MethodImpl] set; }

    public extern FontFamily FontFamily { [MethodImpl] get; [MethodImpl] set; }

    public extern FontWeight FontWeight { [MethodImpl] get; [MethodImpl] set; }

    public extern FontStyle FontStyle { [MethodImpl] get; [MethodImpl] set; }

    public extern FontStretch FontStretch { [MethodImpl] get; [MethodImpl] set; }

    public extern int CharacterSpacing { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush Foreground { [MethodImpl] get; [MethodImpl] set; }

    public extern string Language { [MethodImpl] get; [MethodImpl] set; }

    public extern TextPointer ContentStart { [MethodImpl] get; }

    public extern TextPointer ContentEnd { [MethodImpl] get; }

    public extern TextPointer ElementStart { [MethodImpl] get; }

    public extern TextPointer ElementEnd { [MethodImpl] get; }

    [MethodImpl]
    public extern object FindName(string name);

    [MethodImpl]
    extern void ITextElementOverrides.OnDisconnectVisualChildren();

    public extern bool IsTextScaleFactorEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AllowFocusOnInteraction { [MethodImpl] get; [MethodImpl] set; }

    public extern string AccessKey { [MethodImpl] get; [MethodImpl] set; }

    public extern bool ExitDisplayModeOnAccessKeyInvoked { [MethodImpl] get; [MethodImpl] set; }

    public extern TextDecorations TextDecorations { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsAccessKeyScope { [MethodImpl] get; [MethodImpl] set; }

    public extern DependencyObject AccessKeyScopeOwner { [MethodImpl] get; [MethodImpl] set; }

    public extern KeyTipPlacementMode KeyTipPlacementMode { [MethodImpl] get; [MethodImpl] set; }

    public extern double KeyTipHorizontalOffset { [MethodImpl] get; [MethodImpl] set; }

    public extern double KeyTipVerticalOffset { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<TextElement, AccessKeyDisplayRequestedEventArgs> AccessKeyDisplayRequested;

    public extern event TypedEventHandler<TextElement, AccessKeyDisplayDismissedEventArgs> AccessKeyDisplayDismissed;

    public extern event TypedEventHandler<TextElement, AccessKeyInvokedEventArgs> AccessKeyInvoked;

    public static extern DependencyProperty TextDecorationsProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsAccessKeyScopeProperty { [MethodImpl] get; }

    public static extern DependencyProperty AccessKeyScopeOwnerProperty { [MethodImpl] get; }

    public static extern DependencyProperty KeyTipPlacementModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty KeyTipHorizontalOffsetProperty { [MethodImpl] get; }

    public static extern DependencyProperty KeyTipVerticalOffsetProperty { [MethodImpl] get; }

    public static extern DependencyProperty AllowFocusOnInteractionProperty { [MethodImpl] get; }

    public static extern DependencyProperty AccessKeyProperty { [MethodImpl] get; }

    public static extern DependencyProperty ExitDisplayModeOnAccessKeyInvokedProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsTextScaleFactorEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontSizeProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontFamilyProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontWeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontStyleProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontStretchProperty { [MethodImpl] get; }

    public static extern DependencyProperty CharacterSpacingProperty { [MethodImpl] get; }

    public static extern DependencyProperty ForegroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty LanguageProperty { [MethodImpl] get; }
  }
}
