// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControlStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ExclusiveTo(typeof (MapControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3267762069, 8519, 20234, 148, 42, 84, 147, 168, 93, 232, 7)]
  [WebHostHidden]
  internal interface IMapControlStatics
  {
    DependencyProperty CenterProperty { get; }

    DependencyProperty ChildrenProperty { get; }

    DependencyProperty ColorSchemeProperty { get; }

    DependencyProperty DesiredPitchProperty { get; }

    DependencyProperty HeadingProperty { get; }

    DependencyProperty LandmarksVisibleProperty { get; }

    DependencyProperty LoadingStatusProperty { get; }

    DependencyProperty MapServiceTokenProperty { get; }

    DependencyProperty PedestrianFeaturesVisibleProperty { get; }

    DependencyProperty PitchProperty { get; }

    DependencyProperty StyleProperty { get; }

    DependencyProperty TrafficFlowVisibleProperty { get; }

    DependencyProperty TransformOriginProperty { get; }

    DependencyProperty WatermarkModeProperty { get; }

    DependencyProperty ZoomLevelProperty { get; }

    DependencyProperty MapElementsProperty { get; }

    DependencyProperty RoutesProperty { get; }

    DependencyProperty TileSourcesProperty { get; }

    DependencyProperty LocationProperty { get; }

    Geopoint GetLocation(DependencyObject element);

    void SetLocation(DependencyObject element, Geopoint value);

    DependencyProperty NormalizedAnchorPointProperty { get; }

    Point GetNormalizedAnchorPoint(DependencyObject element);

    void SetNormalizedAnchorPoint(DependencyObject element, Point value);
  }
}
