// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControlTransitFeaturePointerEnteredEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Services.Maps;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ContractVersion(typeof (LocalSearchContract), 196608)]
  [ExclusiveTo(typeof (MapControlTransitFeaturePointerEnteredEventArgs))]
  [Guid(1938889294, 60495, 18334, 148, 161, 54, 224, 129, 208, 216, 151)]
  internal interface IMapControlTransitFeaturePointerEnteredEventArgs
  {
    string DisplayName { get; }

    Geopoint Location { get; }

    IMapView<string, object> TransitProperties { get; }
  }
}
