// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.RadialControllerMenuItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IRadialControllerMenuItemStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772162)]
  [Static(typeof (IRadialControllerMenuItemStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class RadialControllerMenuItem : IRadialControllerMenuItem
  {
    public extern string DisplayText { [MethodImpl] get; }

    public extern object Tag { [MethodImpl] [return: Variant] get; [MethodImpl] [param: Variant] set; }

    public extern event TypedEventHandler<RadialControllerMenuItem, object> Invoked;

    [Overload("CreateFromFontGlyph")]
    [MethodImpl]
    public static extern RadialControllerMenuItem CreateFromFontGlyph(
      string displayText,
      string glyph,
      string fontFamily);

    [Overload("CreateFromFontGlyphWithUri")]
    [MethodImpl]
    public static extern RadialControllerMenuItem CreateFromFontGlyph(
      string displayText,
      string glyph,
      string fontFamily,
      Uri fontUri);

    [MethodImpl]
    public static extern RadialControllerMenuItem CreateFromIcon(
      string displayText,
      RandomAccessStreamReference icon);

    [MethodImpl]
    public static extern RadialControllerMenuItem CreateFromKnownIcon(
      string displayText,
      RadialControllerMenuKnownIcon value);
  }
}
