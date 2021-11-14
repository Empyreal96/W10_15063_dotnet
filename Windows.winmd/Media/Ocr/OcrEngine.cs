// Decompiled with JetBrains decompiler
// Type: Windows.Media.Ocr.OcrEngine
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;
using Windows.Graphics.Imaging;

namespace Windows.Media.Ocr
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IOcrEngineStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class OcrEngine : IOcrEngine
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<OcrResult> RecognizeAsync(
      SoftwareBitmap bitmap);

    public extern Language RecognizerLanguage { [MethodImpl] get; }

    public static extern uint MaxImageDimension { [MethodImpl] get; }

    public static extern IVectorView<Language> AvailableRecognizerLanguages { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool IsLanguageSupported(Language language);

    [MethodImpl]
    public static extern OcrEngine TryCreateFromLanguage(Language language);

    [MethodImpl]
    public static extern OcrEngine TryCreateFromUserProfileLanguages();
  }
}
