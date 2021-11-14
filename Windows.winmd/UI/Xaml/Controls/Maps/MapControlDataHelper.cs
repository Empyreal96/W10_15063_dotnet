// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapControlDataHelper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Services.Maps;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Activatable(typeof (IMapControlDataHelperFactory), 131072, "Windows.Services.Maps.LocalSearchContract")]
  [WebHostHidden]
  [ContractVersion(typeof (LocalSearchContract), 131072)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MapControlDataHelper : 
    DependencyObject,
    IMapControlDataHelper,
    IMapControlDataHelper2
  {
    [MethodImpl]
    public extern MapControlDataHelper(MapControl map);

    public extern event TypedEventHandler<MapControl, MapControlBusinessLandmarkClickEventArgs> BusinessLandmarkClick;

    public extern event TypedEventHandler<MapControl, MapControlTransitFeatureClickEventArgs> TransitFeatureClick;

    public extern event TypedEventHandler<MapControl, MapControlBusinessLandmarkRightTappedEventArgs> BusinessLandmarkRightTapped;

    public extern event TypedEventHandler<MapControl, MapControlTransitFeatureRightTappedEventArgs> TransitFeatureRightTapped;

    public extern event TypedEventHandler<MapControl, MapControlBusinessLandmarkPointerEnteredEventArgs> BusinessLandmarkPointerEntered;

    public extern event TypedEventHandler<MapControl, MapControlTransitFeaturePointerEnteredEventArgs> TransitFeaturePointerEntered;

    public extern event TypedEventHandler<MapControl, MapControlBusinessLandmarkPointerExitedEventArgs> BusinessLandmarkPointerExited;

    public extern event TypedEventHandler<MapControl, MapControlTransitFeaturePointerExitedEventArgs> TransitFeaturePointerExited;
  }
}
