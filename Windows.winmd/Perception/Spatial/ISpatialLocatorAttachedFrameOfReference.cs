// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialLocatorAttachedFrameOfReference
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  [Guid(3782692598, 8015, 18844, 150, 37, 239, 94, 110, 215, 160, 72)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (SpatialLocatorAttachedFrameOfReference))]
  internal interface ISpatialLocatorAttachedFrameOfReference
  {
    Vector3 RelativePosition { get; set; }

    Quaternion RelativeOrientation { get; set; }

    void AdjustHeading(double headingOffsetInRadians);

    SpatialCoordinateSystem GetStationaryCoordinateSystemAtTimestamp(
      PerceptionTimestamp timestamp);

    IReference<double> TryGetRelativeHeadingAtTimestamp(PerceptionTimestamp timestamp);
  }
}
