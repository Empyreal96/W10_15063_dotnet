// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkStrokeBuilder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Inking
{
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.None)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class InkStrokeBuilder : IInkStrokeBuilder, IInkStrokeBuilder2, IInkStrokeBuilder3
  {
    [MethodImpl]
    public extern InkStrokeBuilder();

    [MethodImpl]
    public extern void BeginStroke(PointerPoint pointerPoint);

    [MethodImpl]
    public extern PointerPoint AppendToStroke(PointerPoint pointerPoint);

    [MethodImpl]
    public extern InkStroke EndStroke(PointerPoint pointerPoint);

    [MethodImpl]
    public extern InkStroke CreateStroke(IIterable<Point> points);

    [MethodImpl]
    public extern void SetDefaultDrawingAttributes(InkDrawingAttributes drawingAttributes);

    [MethodImpl]
    public extern InkStroke CreateStrokeFromInkPoints(
      IIterable<InkPoint> inkPoints,
      Matrix3x2 transform);

    [MethodImpl]
    public extern InkStroke CreateStrokeFromInkPoints(
      IIterable<InkPoint> inkPoints,
      Matrix3x2 transform,
      IReference<DateTime> strokeStartedTime,
      IReference<TimeSpan> strokeDuration);
  }
}
