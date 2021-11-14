// Decompiled with JetBrains decompiler
// Type: Windows.Data.Pdf.IPdfDocument
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Pdf
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PdfDocument))]
  [Guid(2893987549, 33018, 16521, 132, 110, 129, 183, 127, 245, 168, 108)]
  internal interface IPdfDocument
  {
    PdfPage GetPage(uint pageIndex);

    uint PageCount { get; }

    bool IsPasswordProtected { get; }
  }
}
