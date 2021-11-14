// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Surfaces.ISpatialSurfaceObserver
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial.Surfaces
{
  [Guid(280401945, 56778, 13443, 172, 58, 116, 143, 232, 200, 109, 245)]
  [ExclusiveTo(typeof (SpatialSurfaceObserver))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialSurfaceObserver
  {
    IMapView<Guid, SpatialSurfaceInfo> GetObservedSurfaces();

    void SetBoundingVolume(SpatialBoundingVolume bounds);

    void SetBoundingVolumes(IIterable<SpatialBoundingVolume> bounds);

    event TypedEventHandler<SpatialSurfaceObserver, object> ObservedSurfacesChanged;
  }
}
