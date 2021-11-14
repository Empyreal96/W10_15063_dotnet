// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialCoordinateSystem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  [ExclusiveTo(typeof (SpatialCoordinateSystem))]
  [Guid(1777060427, 24739, 13702, 166, 83, 89, 167, 189, 103, 109, 7)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialCoordinateSystem
  {
    IReference<Matrix4x4> TryGetTransformTo(SpatialCoordinateSystem target);
  }
}
