// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ITouchHitTestingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ExclusiveTo(typeof (TouchHitTestingEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(586397731, 2940, 16974, 157, 247, 51, 212, 249, 98, 147, 27)]
  internal interface ITouchHitTestingEventArgs : ICoreWindowEventArgs
  {
    CoreProximityEvaluation ProximityEvaluation { get; set; }

    Point Point { get; }

    Rect BoundingBox { get; }

    [DefaultOverload]
    [Overload("EvaluateProximityToRect")]
    CoreProximityEvaluation EvaluateProximity(Rect controlBoundingBox);

    [Overload("EvaluateProximityToPolygon")]
    CoreProximityEvaluation EvaluateProximity(Point[] controlVertices);
  }
}
