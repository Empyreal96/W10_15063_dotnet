// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.TouchHitTestingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class TouchHitTestingEventArgs : ITouchHitTestingEventArgs, ICoreWindowEventArgs
  {
    public extern CoreProximityEvaluation ProximityEvaluation { [MethodImpl] get; [MethodImpl] set; }

    public extern Point Point { [MethodImpl] get; }

    public extern Rect BoundingBox { [MethodImpl] get; }

    [Overload("EvaluateProximityToRect")]
    [DefaultOverload]
    [MethodImpl]
    public extern CoreProximityEvaluation EvaluateProximity(
      Rect controlBoundingBox);

    [Overload("EvaluateProximityToPolygon")]
    [MethodImpl]
    public extern CoreProximityEvaluation EvaluateProximity(
      Point[] controlVertices);

    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
