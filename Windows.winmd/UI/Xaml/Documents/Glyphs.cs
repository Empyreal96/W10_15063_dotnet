// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.Glyphs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Documents
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IGlyphsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IGlyphsStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Glyphs : FrameworkElement, IGlyphs, IGlyphs2
  {
    [MethodImpl]
    public extern Glyphs();

    public extern string UnicodeString { [MethodImpl] get; [MethodImpl] set; }

    public extern string Indices { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri FontUri { [MethodImpl] get; [MethodImpl] set; }

    public extern StyleSimulations StyleSimulations { [MethodImpl] get; [MethodImpl] set; }

    public extern double FontRenderingEmSize { [MethodImpl] get; [MethodImpl] set; }

    public extern double OriginX { [MethodImpl] get; [MethodImpl] set; }

    public extern double OriginY { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush Fill { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsColorFontEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern int ColorFontPaletteIndex { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty IsColorFontEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty ColorFontPaletteIndexProperty { [MethodImpl] get; }

    public static extern DependencyProperty UnicodeStringProperty { [MethodImpl] get; }

    public static extern DependencyProperty IndicesProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontUriProperty { [MethodImpl] get; }

    public static extern DependencyProperty StyleSimulationsProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontRenderingEmSizeProperty { [MethodImpl] get; }

    public static extern DependencyProperty OriginXProperty { [MethodImpl] get; }

    public static extern DependencyProperty OriginYProperty { [MethodImpl] get; }

    public static extern DependencyProperty FillProperty { [MethodImpl] get; }
  }
}
