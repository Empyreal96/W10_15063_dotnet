// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicDisplay
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.Graphics.Holographic
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IHolographicDisplayStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class HolographicDisplay : IHolographicDisplay
  {
    public extern string DisplayName { [MethodImpl] get; }

    public extern Size MaxViewportSize { [MethodImpl] get; }

    public extern bool IsStereo { [MethodImpl] get; }

    public extern bool IsOpaque { [MethodImpl] get; }

    public extern HolographicAdapterId AdapterId { [MethodImpl] get; }

    public extern SpatialLocator SpatialLocator { [MethodImpl] get; }

    [MethodImpl]
    public static extern HolographicDisplay GetDefault();
  }
}
