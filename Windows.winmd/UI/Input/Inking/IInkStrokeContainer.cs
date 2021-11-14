// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStrokeContainer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Input.Inking
{
  [Guid(581749702, 64169, 20244, 182, 140, 246, 206, 230, 112, 174, 22)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IInkStrokeContainer
  {
    Rect BoundingRect { get; }

    void AddStroke(InkStroke stroke);

    Rect DeleteSelected();

    Rect MoveSelected(Point translation);

    Rect SelectWithPolyLine(IIterable<Point> polyline);

    Rect SelectWithLine(Point from, Point to);

    void CopySelectedToClipboard();

    Rect PasteFromClipboard(Point position);

    bool CanPasteFromClipboard();

    [RemoteAsync]
    IAsyncActionWithProgress<ulong> LoadAsync(IInputStream inputStream);

    [Overload("SaveAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<uint, uint> SaveAsync(
      IOutputStream outputStream);

    void UpdateRecognitionResults(
      IVectorView<InkRecognitionResult> recognitionResults);

    IVectorView<InkStroke> GetStrokes();

    IVectorView<InkRecognitionResult> GetRecognitionResults();
  }
}
