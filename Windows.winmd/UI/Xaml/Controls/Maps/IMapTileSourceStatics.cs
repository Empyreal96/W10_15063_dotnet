// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapTileSourceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(2482817340, 28725, 17923, 153, 177, 230, 89, 146, 27, 96, 147)]
  [ExclusiveTo(typeof (MapTileSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IMapTileSourceStatics
  {
    DependencyProperty DataSourceProperty { get; }

    DependencyProperty LayerProperty { get; }

    DependencyProperty ZoomLevelRangeProperty { get; }

    DependencyProperty BoundsProperty { get; }

    DependencyProperty AllowOverstretchProperty { get; }

    DependencyProperty IsFadingEnabledProperty { get; }

    DependencyProperty IsTransparencyEnabledProperty { get; }

    DependencyProperty IsRetryEnabledProperty { get; }

    DependencyProperty ZIndexProperty { get; }

    DependencyProperty TilePixelSizeProperty { get; }

    DependencyProperty VisibleProperty { get; }
  }
}
