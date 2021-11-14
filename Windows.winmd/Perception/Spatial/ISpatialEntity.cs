// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialEntity
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [Guid(376301909, 57835, 17740, 186, 8, 230, 192, 102, 141, 220, 101)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (SpatialEntity))]
  internal interface ISpatialEntity
  {
    string Id { get; }

    SpatialAnchor Anchor { get; }

    ValueSet Properties { get; }
  }
}
