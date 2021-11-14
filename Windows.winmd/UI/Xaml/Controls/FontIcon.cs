// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.FontIcon
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Static(typeof (IFontIconStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Static(typeof (IFontIconStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IFontIconStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IFontIconFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class FontIcon : IconElement, IFontIcon, IFontIcon2, IFontIcon3
  {
    [MethodImpl]
    public extern FontIcon();

    public extern string Glyph { [MethodImpl] get; [MethodImpl] set; }

    public extern double FontSize { [MethodImpl] get; [MethodImpl] set; }

    public extern FontFamily FontFamily { [MethodImpl] get; [MethodImpl] set; }

    public extern FontWeight FontWeight { [MethodImpl] get; [MethodImpl] set; }

    public extern FontStyle FontStyle { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsTextScaleFactorEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool MirroredWhenRightToLeft { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty MirroredWhenRightToLeftProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsTextScaleFactorEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty GlyphProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontSizeProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontFamilyProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontWeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontStyleProperty { [MethodImpl] get; }
  }
}
