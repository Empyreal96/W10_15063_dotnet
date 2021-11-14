// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkStrokeContainer
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
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.None)]
  [DualApiPartition(version = 100794368)]
  public sealed class InkStrokeContainer : 
    IInkStrokeContainer,
    IInkStrokeContainer2,
    IInkStrokeContainer3
  {
    [MethodImpl]
    public extern InkStrokeContainer();

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
    public extern void AddStrokes(IIterable<InkStroke> strokes);

    [MethodImpl]
    public extern void Clear();

    [RemoteAsync]
    [Overload("SaveWithFormatAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<uint, uint> SaveAsync(
      IOutputStream outputStream,
      InkPersistenceFormat inkPersistenceFormat);

    [MethodImpl]
    public extern InkStroke GetStrokeById(uint id);
  }
}
