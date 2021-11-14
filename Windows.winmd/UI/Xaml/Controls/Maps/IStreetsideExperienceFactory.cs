// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IStreetsideExperienceFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(2052837180, 25758, 17218, 153, 149, 104, 166, 207, 89, 97, 167)]
  [ExclusiveTo(typeof (StreetsideExperience))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IStreetsideExperienceFactory
  {
    StreetsideExperience CreateInstanceWithPanorama(StreetsidePanorama panorama);

    StreetsideExperience CreateInstanceWithPanoramaHeadingPitchAndFieldOfView(
      StreetsidePanorama panorama,
      double headingInDegrees,
      double pitchInDegrees,
      double fieldOfViewInDegrees);
  }
}
