// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControlTransitFeaturePointerExitedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Services.Maps;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ExclusiveTo(typeof (MapControlTransitFeaturePointerExitedEventArgs))]
  [WebHostHidden]
  [Guid(1779508621, 17549, 17639, 188, 105, 209, 61, 73, 113, 84, 233)]
  [ContractVersion(typeof (LocalSearchContract), 196608)]
  internal interface IMapControlTransitFeaturePointerExitedEventArgs
  {
    string DisplayName { get; }

    Geopoint Location { get; }

    IMapView<string, object> TransitProperties { get; }
  }
}
