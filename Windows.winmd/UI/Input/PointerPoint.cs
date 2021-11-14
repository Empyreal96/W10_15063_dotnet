// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.PointerPoint
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [MarshalingBehavior(MarshalingType.None)]
  [Static(typeof (IPointerPointStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PointerPoint : IPointerPoint
  {
    public extern PointerDevice PointerDevice { [MethodImpl] get; }

    public extern Point Position { [MethodImpl] get; }

    public extern Point RawPosition { [MethodImpl] get; }

    public extern uint PointerId { [MethodImpl] get; }

    public extern uint FrameId { [MethodImpl] get; }

    public extern ulong Timestamp { [MethodImpl] get; }

    public extern bool IsInContact { [MethodImpl] get; }

    public extern PointerPointProperties Properties { [MethodImpl] get; }

    [Overload("GetCurrentPoint")]
    [MethodImpl]
    public static extern PointerPoint GetCurrentPoint(uint pointerId);

    [Overload("GetIntermediatePoints")]
    [MethodImpl]
    public static extern IVector<PointerPoint> GetIntermediatePoints(
      uint pointerId);

    [Overload("GetCurrentPointTransformed")]
    [MethodImpl]
    public static extern PointerPoint GetCurrentPoint(
      uint pointerId,
      IPointerPointTransform transform);

    [Overload("GetIntermediatePointsTransformed")]
    [MethodImpl]
    public static extern IVector<PointerPoint> GetIntermediatePoints(
      uint pointerId,
      IPointerPointTransform transform);
  }
}
