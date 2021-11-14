// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicDisplay
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.Graphics.Holographic
{
  [ExclusiveTo(typeof (HolographicDisplay))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2597233684, 7583, 16528, 163, 136, 144, 192, 111, 110, 174, 156)]
  internal interface IHolographicDisplay
  {
    string DisplayName { get; }

    Size MaxViewportSize { get; }

    bool IsStereo { get; }

    bool IsOpaque { get; }

    HolographicAdapterId AdapterId { get; }

    SpatialLocator SpatialLocator { get; }
  }
}
