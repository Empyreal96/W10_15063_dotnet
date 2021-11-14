// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkRecognizerContainer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2806880817, 32839, 18072, 169, 18, 248, 42, 80, 133, 1, 47)]
  public interface IInkRecognizerContainer
  {
    void SetDefaultRecognizer(InkRecognizer recognizer);

    [RemoteAsync]
    IAsyncOperation<IVectorView<InkRecognitionResult>> RecognizeAsync(
      InkStrokeContainer strokeCollection,
      InkRecognitionTarget recognitionTarget);

    IVectorView<InkRecognizer> GetRecognizers();
  }
}
