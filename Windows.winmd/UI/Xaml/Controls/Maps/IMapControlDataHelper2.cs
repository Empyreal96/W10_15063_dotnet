// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControlDataHelper2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Services.Maps;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [Guid(1506689694, 22063, 19489, 166, 116, 15, 17, 222, 207, 15, 179)]
  [ExclusiveTo(typeof (MapControlDataHelper))]
  [ContractVersion(typeof (LocalSearchContract), 196608)]
  internal interface IMapControlDataHelper2
  {
    event TypedEventHandler<MapControl, MapControlBusinessLandmarkPointerEnteredEventArgs> BusinessLandmarkPointerEntered;

    event TypedEventHandler<MapControl, MapControlTransitFeaturePointerEnteredEventArgs> TransitFeaturePointerEntered;

    event TypedEventHandler<MapControl, MapControlBusinessLandmarkPointerExitedEventArgs> BusinessLandmarkPointerExited;

    event TypedEventHandler<MapControl, MapControlTransitFeaturePointerExitedEventArgs> TransitFeaturePointerExited;
  }
}
