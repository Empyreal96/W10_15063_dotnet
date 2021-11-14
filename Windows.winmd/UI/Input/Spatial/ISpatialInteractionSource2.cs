// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionSource2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception;

namespace Windows.UI.Input.Spatial
{
  [Guid(3838162700, 1136, 16424, 136, 192, 160, 235, 68, 211, 78, 254)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (SpatialInteractionSource))]
  internal interface ISpatialInteractionSource2 : ISpatialInteractionSource
  {
    bool IsPointingSupported { get; }

    bool IsMenuSupported { get; }

    bool IsGraspSupported { get; }

    SpatialInteractionController Controller { get; }

    SpatialInteractionSourceState TryGetStateAtTimestamp(
      PerceptionTimestamp timestamp);
  }
}
