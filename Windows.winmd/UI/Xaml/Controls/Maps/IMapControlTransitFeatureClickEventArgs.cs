// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControlTransitFeatureClickEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Services.Maps;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ExclusiveTo(typeof (MapControlTransitFeatureClickEventArgs))]
  [ContractVersion(typeof (LocalSearchContract), 131072)]
  [WebHostHidden]
  [Guid(1981258089, 46949, 17954, 176, 138, 48, 114, 116, 90, 69, 65)]
  internal interface IMapControlTransitFeatureClickEventArgs
  {
    string DisplayName { get; }

    Geopoint Location { get; }

    IMapView<string, object> TransitProperties { get; }
  }
}
