// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IStreetsidePanoramaStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ExclusiveTo(typeof (StreetsidePanorama))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3551821673, 21683, 20165, 178, 160, 79, 130, 4, 87, 101, 7)]
  [WebHostHidden]
  internal interface IStreetsidePanoramaStatics
  {
    [Overload("FindNearbyWithLocationAsync")]
    [RemoteAsync]
    IAsyncOperation<StreetsidePanorama> FindNearbyAsync(
      Geopoint location);

    [RemoteAsync]
    [Overload("FindNearbyWithLocationAndRadiusAsync")]
    IAsyncOperation<StreetsidePanorama> FindNearbyAsync(
      Geopoint location,
      double radiusInMeters);
  }
}
