// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapCameraFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(3929739030, 33711, 19150, 142, 113, 16, 173, 159, 30, 158, 127)]
  [ExclusiveTo(typeof (MapCamera))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IMapCameraFactory
  {
    MapCamera CreateInstanceWithLocation(Geopoint location);

    MapCamera CreateInstanceWithLocationAndHeading(
      Geopoint location,
      double headingInDegrees);

    MapCamera CreateInstanceWithLocationHeadingAndPitch(
      Geopoint location,
      double headingInDegrees,
      double pitchInDegrees);

    MapCamera CreateInstanceWithLocationHeadingPitchRollAndFieldOfView(
      Geopoint location,
      double headingInDegrees,
      double pitchInDegrees,
      double rollInDegrees,
      double fieldOfViewInDegrees);
  }
}
