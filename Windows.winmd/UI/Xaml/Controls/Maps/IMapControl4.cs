// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControl4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(110039850, 6167, 18029, 183, 206, 65, 155, 63, 142, 36, 139)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MapControl))]
  internal interface IMapControl4
  {
    bool BusinessLandmarksEnabled { get; set; }

    bool TransitFeaturesEnabled { get; set; }

    Geopath GetVisibleRegion(MapVisibleRegionKind region);
  }
}
