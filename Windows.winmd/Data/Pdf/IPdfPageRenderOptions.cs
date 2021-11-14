// Decompiled with JetBrains decompiler
// Type: Windows.Data.Pdf.IPdfPageRenderOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Data.Pdf
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1016595823, 47055, 19497, 154, 4, 82, 217, 2, 103, 244, 37)]
  [ExclusiveTo(typeof (PdfPageRenderOptions))]
  internal interface IPdfPageRenderOptions
  {
    Rect SourceRect { get; set; }

    uint DestinationWidth { get; set; }

    uint DestinationHeight { get; set; }

    Color BackgroundColor { get; set; }

    bool IsIgnoringHighContrast { get; set; }

    Guid BitmapEncoderId { get; set; }
  }
}
