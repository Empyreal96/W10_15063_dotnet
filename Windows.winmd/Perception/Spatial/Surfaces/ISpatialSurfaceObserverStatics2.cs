// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Surfaces.ISpatialSurfaceObserverStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial.Surfaces
{
  [ExclusiveTo(typeof (SpatialSurfaceObserver))]
  [Guid(257114721, 50525, 20075, 168, 149, 161, 157, 230, 154, 66, 227)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISpatialSurfaceObserverStatics2 : ISpatialSurfaceObserverStatics
  {
    bool IsSupported();
  }
}
