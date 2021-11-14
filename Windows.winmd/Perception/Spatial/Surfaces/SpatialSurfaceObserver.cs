// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Surfaces.SpatialSurfaceObserver
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial.Surfaces
{
  [Static(typeof (ISpatialSurfaceObserverStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(131072, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Static(typeof (ISpatialSurfaceObserverStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class SpatialSurfaceObserver : ISpatialSurfaceObserver
  {
    [MethodImpl]
    public extern SpatialSurfaceObserver();

    [MethodImpl]
    public extern IMapView<Guid, SpatialSurfaceInfo> GetObservedSurfaces();

    [MethodImpl]
    public extern void SetBoundingVolume(SpatialBoundingVolume bounds);

    [MethodImpl]
    public extern void SetBoundingVolumes(IIterable<SpatialBoundingVolume> bounds);

    public extern event TypedEventHandler<SpatialSurfaceObserver, object> ObservedSurfacesChanged;

    [MethodImpl]
    public static extern bool IsSupported();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<SpatialPerceptionAccessStatus> RequestAccessAsync();
  }
}
