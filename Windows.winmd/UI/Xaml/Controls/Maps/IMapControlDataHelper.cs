// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControlDataHelper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Services.Maps;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (LocalSearchContract), 131072)]
  [Guid(2343628956, 5291, 18540, 157, 229, 90, 93, 239, 2, 5, 162)]
  [ExclusiveTo(typeof (MapControlDataHelper))]
  [WebHostHidden]
  internal interface IMapControlDataHelper
  {
    event TypedEventHandler<MapControl, MapControlBusinessLandmarkClickEventArgs> BusinessLandmarkClick;

    event TypedEventHandler<MapControl, MapControlTransitFeatureClickEventArgs> TransitFeatureClick;

    event TypedEventHandler<MapControl, MapControlBusinessLandmarkRightTappedEventArgs> BusinessLandmarkRightTapped;

    event TypedEventHandler<MapControl, MapControlTransitFeatureRightTappedEventArgs> TransitFeatureRightTapped;
  }
}
