// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialAnchor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [ExclusiveTo(typeof (SpatialAnchor))]
  [Guid(86631886, 7476, 14082, 188, 236, 234, 191, 245, 120, 168, 105)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialAnchor
  {
    SpatialCoordinateSystem CoordinateSystem { get; }

    SpatialCoordinateSystem RawCoordinateSystem { get; }

    event TypedEventHandler<SpatialAnchor, SpatialAnchorRawCoordinateSystemAdjustedEventArgs> RawCoordinateSystemAdjusted;
  }
}
