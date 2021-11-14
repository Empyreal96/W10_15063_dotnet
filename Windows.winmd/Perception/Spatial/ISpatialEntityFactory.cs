// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialEntityFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [Guid(3790725925, 13471, 16933, 162, 243, 75, 1, 193, 95, 224, 86)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (SpatialEntity))]
  internal interface ISpatialEntityFactory
  {
    SpatialEntity CreateWithSpatialAnchor(SpatialAnchor spatialAnchor);

    SpatialEntity CreateWithSpatialAnchorAndProperties(
      SpatialAnchor spatialAnchor,
      ValueSet propertySet);
  }
}
