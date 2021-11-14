// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialManipulationUpdatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.UI.Input.Spatial
{
  [ExclusiveTo(typeof (SpatialManipulationUpdatedEventArgs))]
  [Guid(1596132251, 24774, 19910, 189, 201, 159, 74, 111, 21, 254, 73)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialManipulationUpdatedEventArgs
  {
    SpatialInteractionSourceKind InteractionSourceKind { get; }

    SpatialManipulationDelta TryGetCumulativeDelta(
      SpatialCoordinateSystem coordinateSystem);
  }
}
