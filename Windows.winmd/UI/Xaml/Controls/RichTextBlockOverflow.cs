// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.RichTextBlockOverflow
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Documents;

namespace Windows.UI.Xaml.Controls
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IRichTextBlockOverflowStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRichTextBlockOverflowStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class RichTextBlockOverflow : 
    FrameworkElement,
    IRichTextBlockOverflow,
    IRichTextBlockOverflow2
  {
    [MethodImpl]
    public extern RichTextBlockOverflow();

    public extern RichTextBlockOverflow OverflowContentTarget { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness Padding { [MethodImpl] get; [MethodImpl] set; }

    public extern RichTextBlock ContentSource { [MethodImpl] get; }

    public extern bool HasOverflowContent { [MethodImpl] get; }

    public extern TextPointer ContentStart { [MethodImpl] get; }

    public extern TextPointer ContentEnd { [MethodImpl] get; }

    public extern double BaselineOffset { [MethodImpl] get; }

    [MethodImpl]
    public extern TextPointer GetPositionFromPoint(Point point);

    [MethodImpl]
    public extern bool Focus(FocusState value);

    public extern int MaxLines { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty MaxLinesProperty { [MethodImpl] get; }

    public static extern DependencyProperty OverflowContentTargetProperty { [MethodImpl] get; }

    public static extern DependencyProperty PaddingProperty { [MethodImpl] get; }

    public static extern DependencyProperty HasOverflowContentProperty { [MethodImpl] get; }
  }
}
