// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Surfaces.ISpatialSurfaceObserverStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial.Surfaces
{
  [ExclusiveTo(typeof (SpatialSurfaceObserver))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(374952429, 8456, 16744, 145, 117, 135, 224, 39, 188, 146, 133)]
  internal interface ISpatialSurfaceObserverStatics
  {
    [RemoteAsync]
    IAsyncOperation<SpatialPerceptionAccessStatus> RequestAccessAsync();
  }
}
