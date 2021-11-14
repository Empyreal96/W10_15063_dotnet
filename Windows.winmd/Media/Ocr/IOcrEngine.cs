// Decompiled with JetBrains decompiler
// Type: Windows.Media.Ocr.IOcrEngine
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;
using Windows.Graphics.Imaging;

namespace Windows.Media.Ocr
{
  [ExclusiveTo(typeof (OcrEngine))]
  [Guid(1511308353, 23414, 12608, 182, 128, 136, 37, 86, 38, 131, 172)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IOcrEngine
  {
    [RemoteAsync]
    IAsyncOperation<OcrResult> RecognizeAsync(SoftwareBitmap bitmap);

    Language RecognizerLanguage { get; }
  }
}
