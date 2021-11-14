// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialAnchorStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [Guid(2965124662, 18538, 15536, 158, 111, 18, 69, 22, 92, 77, 182)]
  [ExclusiveTo(typeof (SpatialAnchorStore))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialAnchorStore
  {
    IMapView<string, SpatialAnchor> GetAllSavedAnchors();

    bool TrySave(string id, SpatialAnchor anchor);

    void Remove(string id);

    void Clear();
  }
}
