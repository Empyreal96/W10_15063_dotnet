// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStrokeRenderingSegment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (InkStrokeRenderingSegment))]
  [Guid(1750142751, 35043, 18298, 162, 250, 86, 159, 95, 31, 155, 213)]
  internal interface IInkStrokeRenderingSegment
  {
    Point Position { get; }

    Point BezierControlPoint1 { get; }

    Point BezierControlPoint2 { get; }

    float Pressure { get; }

    float TiltX { get; }

    float TiltY { get; }

    float Twist { get; }
  }
}
