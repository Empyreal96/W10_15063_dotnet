// Decompiled with JetBrains decompiler
// Type: Windows.Media.Ocr.IOcrResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Ocr
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2614244786, 5979, 15722, 146, 226, 56, 140, 32, 110, 47, 99)]
  [ExclusiveTo(typeof (OcrResult))]
  internal interface IOcrResult
  {
    IVectorView<OcrLine> Lines { get; }

    IReference<double> TextAngle { get; }

    string Text { get; }
  }
}
