// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Perception;

namespace Windows.UI.Input.Spatial
{
  [ExclusiveTo(typeof (SpatialInteractionManager))]
  [Guid(849759912, 41306, 14741, 184, 189, 128, 81, 60, 181, 173, 239)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialInteractionManager
  {
    event TypedEventHandler<SpatialInteractionManager, SpatialInteractionSourceEventArgs> SourceDetected;

    event TypedEventHandler<SpatialInteractionManager, SpatialInteractionSourceEventArgs> SourceLost;

    event TypedEventHandler<SpatialInteractionManager, SpatialInteractionSourceEventArgs> SourceUpdated;

    event TypedEventHandler<SpatialInteractionManager, SpatialInteractionSourceEventArgs> SourcePressed;

    event TypedEventHandler<SpatialInteractionManager, SpatialInteractionSourceEventArgs> SourceReleased;

    event TypedEventHandler<SpatialInteractionManager, SpatialInteractionDetectedEventArgs> InteractionDetected;

    IVectorView<SpatialInteractionSourceState> GetDetectedSourcesAtTimestamp(
      PerceptionTimestamp timeStamp);
  }
}
