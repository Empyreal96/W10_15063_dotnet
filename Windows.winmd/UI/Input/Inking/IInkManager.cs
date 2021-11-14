// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ExclusiveTo(typeof (InkManager))]
  [Guid(1195668349, 26395, 16739, 156, 149, 78, 141, 122, 3, 95, 225)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IInkManager : IInkStrokeContainer, IInkRecognizerContainer
  {
    InkManipulationMode Mode { get; set; }

    void ProcessPointerDown(PointerPoint pointerPoint);

    [return: Variant]
    object ProcessPointerUpdate(PointerPoint pointerPoint);

    Rect ProcessPointerUp(PointerPoint pointerPoint);

    void SetDefaultDrawingAttributes(InkDrawingAttributes drawingAttributes);

    [RemoteAsync]
    [Overload("RecognizeAsync2")]
    IAsyncOperation<IVectorView<InkRecognitionResult>> RecognizeAsync(
      InkRecognitionTarget recognitionTarget);
  }
}
