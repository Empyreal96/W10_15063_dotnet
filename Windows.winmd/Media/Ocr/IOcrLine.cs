// Decompiled with JetBrains decompiler
// Type: Windows.Media.Ocr.IOcrLine
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Ocr
{
  [ExclusiveTo(typeof (OcrLine))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4432239, 58143, 14884, 137, 156, 212, 68, 189, 8, 129, 36)]
  internal interface IOcrLine
  {
    IVectorView<OcrWord> Words { get; }

    string Text { get; }
  }
}
