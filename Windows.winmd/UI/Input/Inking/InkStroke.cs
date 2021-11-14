// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkStroke
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
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class InkStroke : IInkStroke, IInkStroke2, IInkStroke3
  {
    public extern InkDrawingAttributes DrawingAttributes { [MethodImpl] get; [MethodImpl] set; }

    public extern Rect BoundingRect { [MethodImpl] get; }

    public extern bool Selected { [MethodImpl] get; [MethodImpl] set; }

    public extern bool Recognized { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<InkStrokeRenderingSegment> GetRenderingSegments();

    [MethodImpl]
    public extern InkStroke Clone();

    public extern Matrix3x2 PointTransform { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern IVectorView<InkPoint> GetInkPoints();

    public extern uint Id { [MethodImpl] get; }

    public extern IReference<DateTime> StrokeStartedTime { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<TimeSpan> StrokeDuration { [MethodImpl] get; [MethodImpl] set; }
  }
}
