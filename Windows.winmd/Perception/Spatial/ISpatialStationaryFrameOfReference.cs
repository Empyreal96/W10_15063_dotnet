// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialStationaryFrameOfReference
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [ExclusiveTo(typeof (SpatialStationaryFrameOfReference))]
  [Guid(165399737, 48376, 15999, 190, 126, 126, 220, 203, 177, 120, 168)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialStationaryFrameOfReference
  {
    SpatialCoordinateSystem CoordinateSystem { get; }
  }
}
