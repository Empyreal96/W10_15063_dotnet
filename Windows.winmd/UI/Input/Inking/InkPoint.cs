// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkPoint
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Activatable(typeof (IInkPointFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IInkPointFactory2), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class InkPoint : IInkPoint, IInkPoint2
  {
    [MethodImpl]
    public extern InkPoint(
      Point position,
      float pressure,
      float tiltX,
      float tiltY,
      ulong timestamp);

    [MethodImpl]
    public extern InkPoint(Point position, float pressure);

    public extern Point Position { [MethodImpl] get; }

    public extern float Pressure { [MethodImpl] get; }

    public extern float TiltX { [MethodImpl] get; }

    public extern float TiltY { [MethodImpl] get; }

    public extern ulong Timestamp { [MethodImpl] get; }
  }
}
