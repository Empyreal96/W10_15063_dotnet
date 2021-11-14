// Decompiled with JetBrains decompiler
// Type: Windows.Data.Pdf.PdfPageRenderOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Data.Pdf
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PdfPageRenderOptions : IPdfPageRenderOptions
  {
    [MethodImpl]
    public extern PdfPageRenderOptions();

    public extern Rect SourceRect { [MethodImpl] get; [MethodImpl] set; }

    public extern uint DestinationWidth { [MethodImpl] get; [MethodImpl] set; }

    public extern uint DestinationHeight { [MethodImpl] get; [MethodImpl] set; }

    public extern Color BackgroundColor { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsIgnoringHighContrast { [MethodImpl] get; [MethodImpl] set; }

    public extern Guid BitmapEncoderId { [MethodImpl] get; [MethodImpl] set; }
  }
}
