// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialManipulationCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.UI.Input.Spatial
{
  [Guid(84436994, 62209, 17219, 146, 80, 47, 186, 165, 248, 122, 55)]
  [ExclusiveTo(typeof (SpatialManipulationCompletedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialManipulationCompletedEventArgs
  {
    SpatialInteractionSourceKind InteractionSourceKind { get; }

    SpatialManipulationDelta TryGetCumulativeDelta(
      SpatialCoordinateSystem coordinateSystem);
  }
}
