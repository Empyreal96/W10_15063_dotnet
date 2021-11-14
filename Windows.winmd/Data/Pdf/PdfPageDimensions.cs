// Decompiled with JetBrains decompiler
// Type: Windows.Data.Pdf.PdfPageDimensions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Pdf
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PdfPageDimensions : IPdfPageDimensions
  {
    public extern Rect MediaBox { [MethodImpl] get; }

    public extern Rect CropBox { [MethodImpl] get; }

    public extern Rect BleedBox { [MethodImpl] get; }

    public extern Rect TrimBox { [MethodImpl] get; }

    public extern Rect ArtBox { [MethodImpl] get; }
  }
}
