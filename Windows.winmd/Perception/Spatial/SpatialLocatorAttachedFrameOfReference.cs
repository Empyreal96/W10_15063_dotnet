// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialLocatorAttachedFrameOfReference
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class SpatialLocatorAttachedFrameOfReference : 
    ISpatialLocatorAttachedFrameOfReference
  {
    public extern Vector3 RelativePosition { [MethodImpl] get; [MethodImpl] set; }

    public extern Quaternion RelativeOrientation { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void AdjustHeading(double headingOffsetInRadians);

    [MethodImpl]
    public extern SpatialCoordinateSystem GetStationaryCoordinateSystemAtTimestamp(
      PerceptionTimestamp timestamp);

    [MethodImpl]
    public extern IReference<double> TryGetRelativeHeadingAtTimestamp(
      PerceptionTimestamp timestamp);
  }
}
