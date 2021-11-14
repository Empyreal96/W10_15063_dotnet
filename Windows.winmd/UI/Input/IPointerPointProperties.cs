// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IPointerPointProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [Guid(3348990539, 49507, 20199, 128, 63, 103, 206, 121, 249, 151, 45)]
  [ExclusiveTo(typeof (PointerPointProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPointerPointProperties
  {
    float Pressure { get; }

    bool IsInverted { get; }

    bool IsEraser { get; }

    float Orientation { get; }

    float XTilt { get; }

    float YTilt { get; }

    float Twist { get; }

    Rect ContactRect { get; }

    Rect ContactRectRaw { get; }

    bool TouchConfidence { get; }

    bool IsLeftButtonPressed { get; }

    bool IsRightButtonPressed { get; }

    bool IsMiddleButtonPressed { get; }

    int MouseWheelDelta { get; }

    bool IsHorizontalMouseWheel { get; }

    bool IsPrimary { get; }

    bool IsInRange { get; }

    bool IsCanceled { get; }

    bool IsBarrelButtonPressed { get; }

    bool IsXButton1Pressed { get; }

    bool IsXButton2Pressed { get; }

    PointerUpdateKind PointerUpdateKind { get; }

    bool HasUsage(uint usagePage, uint usageId);

    int GetUsageValue(uint usagePage, uint usageId);
  }
}
