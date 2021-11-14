// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionSourceProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Perception.Spatial;

namespace Windows.UI.Input.Spatial
{
  [Guid(90195266, 16119, 12834, 159, 83, 99, 201, 203, 126, 59, 199)]
  [ExclusiveTo(typeof (SpatialInteractionSourceProperties))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialInteractionSourceProperties
  {
    IReference<Vector3> TryGetSourceLossMitigationDirection(
      SpatialCoordinateSystem coordinateSystem);

    double SourceLossRisk { get; }

    SpatialInteractionSourceLocation TryGetLocation(
      SpatialCoordinateSystem coordinateSystem);
  }
}
