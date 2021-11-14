// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicCamera
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class HolographicCamera : IHolographicCamera, IHolographicCamera2
  {
    public extern Size RenderTargetSize { [MethodImpl] get; }

    public extern double ViewportScaleFactor { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsStereo { [MethodImpl] get; }

    public extern uint Id { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetNearPlaneDistance(double value);

    [MethodImpl]
    public extern void SetFarPlaneDistance(double value);

    public extern HolographicCameraViewportParameters LeftViewportParameters { [MethodImpl] get; }

    public extern HolographicCameraViewportParameters RightViewportParameters { [MethodImpl] get; }

    public extern HolographicDisplay Display { [MethodImpl] get; }
  }
}
