// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkDrawingAttributes
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Inking
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IInkDrawingAttributesStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class InkDrawingAttributes : 
    IInkDrawingAttributes,
    IInkDrawingAttributes2,
    IInkDrawingAttributes3,
    IInkDrawingAttributes4
  {
    [MethodImpl]
    public extern InkDrawingAttributes();

    public extern Color Color { [MethodImpl] get; [MethodImpl] set; }

    public extern PenTipShape PenTip { [MethodImpl] get; [MethodImpl] set; }

    public extern Size Size { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IgnorePressure { [MethodImpl] get; [MethodImpl] set; }

    public extern bool FitToCurve { [MethodImpl] get; [MethodImpl] set; }

    public extern Matrix3x2 PenTipTransform { [MethodImpl] get; [MethodImpl] set; }

    public extern bool DrawAsHighlighter { [MethodImpl] get; [MethodImpl] set; }

    public extern InkDrawingAttributesKind Kind { [MethodImpl] get; }

    public extern InkDrawingAttributesPencilProperties PencilProperties { [MethodImpl] get; }

    public extern bool IgnoreTilt { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public static extern InkDrawingAttributes CreateForPencil();
  }
}
