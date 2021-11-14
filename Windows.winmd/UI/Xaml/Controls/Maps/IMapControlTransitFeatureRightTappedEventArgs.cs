// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControlTransitFeatureRightTappedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Services.Maps;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(2929839177, 42793, 20142, 165, 154, 62, 201, 161, 37, 160, 40)]
  [WebHostHidden]
  [ContractVersion(typeof (LocalSearchContract), 131072)]
  [ExclusiveTo(typeof (MapControlTransitFeatureRightTappedEventArgs))]
  internal interface IMapControlTransitFeatureRightTappedEventArgs
  {
    string DisplayName { get; }

    Geopoint Location { get; }

    IMapView<string, object> TransitProperties { get; }
  }
}
