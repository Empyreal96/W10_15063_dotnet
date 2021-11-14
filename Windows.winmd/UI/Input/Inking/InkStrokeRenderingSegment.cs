// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkStrokeRenderingSegment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  public sealed class InkStrokeRenderingSegment : IInkStrokeRenderingSegment
  {
    public extern Point Position { [MethodImpl] get; }

    public extern Point BezierControlPoint1 { [MethodImpl] get; }

    public extern Point BezierControlPoint2 { [MethodImpl] get; }

    public extern float Pressure { [MethodImpl] get; }

    public extern float TiltX { [MethodImpl] get; }

    public extern float TiltY { [MethodImpl] get; }

    public extern float Twist { [MethodImpl] get; }
  }
}
