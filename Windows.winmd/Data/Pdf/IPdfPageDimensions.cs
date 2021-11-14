// Decompiled with JetBrains decompiler
// Type: Windows.Data.Pdf.IPdfPageDimensions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Pdf
{
  [ExclusiveTo(typeof (PdfPageDimensions))]
  [Guid(571933809, 12606, 17640, 131, 93, 99, 163, 231, 98, 74, 16)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPdfPageDimensions
  {
    Rect MediaBox { get; }

    Rect CropBox { get; }

    Rect BleedBox { get; }

    Rect TrimBox { get; }

    Rect ArtBox { get; }
  }
}
