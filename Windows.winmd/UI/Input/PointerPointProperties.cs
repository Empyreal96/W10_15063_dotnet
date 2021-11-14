// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.PointerPointProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.None)]
  public sealed class PointerPointProperties : IPointerPointProperties, IPointerPointProperties2
  {
    public extern float Pressure { [MethodImpl] get; }

    public extern bool IsInverted { [MethodImpl] get; }

    public extern bool IsEraser { [MethodImpl] get; }

    public extern float Orientation { [MethodImpl] get; }

    public extern float XTilt { [MethodImpl] get; }

    public extern float YTilt { [MethodImpl] get; }

    public extern float Twist { [MethodImpl] get; }

    public extern Rect ContactRect { [MethodImpl] get; }

    public extern Rect ContactRectRaw { [MethodImpl] get; }

    public extern bool TouchConfidence { [MethodImpl] get; }

    public extern bool IsLeftButtonPressed { [MethodImpl] get; }

    public extern bool IsRightButtonPressed { [MethodImpl] get; }

    public extern bool IsMiddleButtonPressed { [MethodImpl] get; }

    public extern int MouseWheelDelta { [MethodImpl] get; }

    public extern bool IsHorizontalMouseWheel { [MethodImpl] get; }

    public extern bool IsPrimary { [MethodImpl] get; }

    public extern bool IsInRange { [MethodImpl] get; }

    public extern bool IsCanceled { [MethodImpl] get; }

    public extern bool IsBarrelButtonPressed { [MethodImpl] get; }

    public extern bool IsXButton1Pressed { [MethodImpl] get; }

    public extern bool IsXButton2Pressed { [MethodImpl] get; }

    public extern PointerUpdateKind PointerUpdateKind { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasUsage(uint usagePage, uint usageId);

    [MethodImpl]
    public extern int GetUsageValue(uint usagePage, uint usageId);

    public extern IReference<float> ZDistance { [MethodImpl] get; }
  }
}
