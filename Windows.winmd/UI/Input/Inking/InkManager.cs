// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.None)]
  [DualApiPartition(version = 100794368)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class InkManager : IInkManager, IInkRecognizerContainer, IInkStrokeContainer
  {
    [MethodImpl]
    public extern InkManager();

    public extern InkManipulationMode Mode { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void ProcessPointerDown(PointerPoint pointerPoint);

    [MethodImpl]
    [return: Variant]
    public extern object ProcessPointerUpdate(PointerPoint pointerPoint);

    [MethodImpl]
    public extern Rect ProcessPointerUp(PointerPoint pointerPoint);

    [MethodImpl]
    public extern void SetDefaultDrawingAttributes(InkDrawingAttributes drawingAttributes);

    [RemoteAsync]
    [Overload("RecognizeAsync2")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<InkRecognitionResult>> RecognizeAsync(
      InkRecognitionTarget recognitionTarget);

    public extern Rect BoundingRect { [MethodImpl] get; }

    [MethodImpl]
    public extern void AddStroke(InkStroke stroke);

    [MethodImpl]
    public extern Rect DeleteSelected();

    [MethodImpl]
    public extern Rect MoveSelected(Point translation);

    [MethodImpl]
    public extern Rect SelectWithPolyLine(IIterable<Point> polyline);

    [MethodImpl]
    public extern Rect SelectWithLine(Point from, Point to);

    [MethodImpl]
    public extern void CopySelectedToClipboard();

    [MethodImpl]
    public extern Rect PasteFromClipboard(Point position);

    [MethodImpl]
    public extern bool CanPasteFromClipboard();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncActionWithProgress<ulong> LoadAsync(
      IInputStream inputStream);

    [RemoteAsync]
    [Overload("SaveAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<uint, uint> SaveAsync(
      IOutputStream outputStream);

    [MethodImpl]
    public extern void UpdateRecognitionResults(
      IVectorView<InkRecognitionResult> recognitionResults);

    [MethodImpl]
    public extern IVectorView<InkStroke> GetStrokes();

    [MethodImpl]
    public extern IVectorView<InkRecognitionResult> GetRecognitionResults();

    [MethodImpl]
    public extern void SetDefaultRecognizer(InkRecognizer recognizer);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<InkRecognitionResult>> RecognizeAsync(
      InkStrokeContainer strokeCollection,
      InkRecognitionTarget recognitionTarget);

    [MethodImpl]
    public extern IVectorView<InkRecognizer> GetRecognizers();
  }
}
