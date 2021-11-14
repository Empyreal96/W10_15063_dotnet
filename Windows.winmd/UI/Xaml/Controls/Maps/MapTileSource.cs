// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapTileSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IMapTileSourceFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapTileSourceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public class MapTileSource : DependencyObject, IMapTileSource
  {
    [MethodImpl]
    public extern MapTileSource();

    [MethodImpl]
    public extern MapTileSource(MapTileDataSource dataSource);

    [MethodImpl]
    public extern MapTileSource(MapTileDataSource dataSource, MapZoomLevelRange zoomLevelRange);

    [MethodImpl]
    public extern MapTileSource(
      MapTileDataSource dataSource,
      MapZoomLevelRange zoomLevelRange,
      GeoboundingBox bounds);

    [MethodImpl]
    public extern MapTileSource(
      MapTileDataSource dataSource,
      MapZoomLevelRange zoomLevelRange,
      GeoboundingBox bounds,
      int tileSizeInPixels);

    public extern MapTileDataSource DataSource { [MethodImpl] get; [MethodImpl] set; }

    public extern MapTileLayer Layer { [MethodImpl] get; [MethodImpl] set; }

    public extern MapZoomLevelRange ZoomLevelRange { [MethodImpl] get; [MethodImpl] set; }

    public extern GeoboundingBox Bounds { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AllowOverstretch { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsFadingEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsTransparencyEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsRetryEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern int ZIndex { [MethodImpl] get; [MethodImpl] set; }

    public extern int TilePixelSize { [MethodImpl] get; [MethodImpl] set; }

    public extern bool Visible { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty DataSourceProperty { [MethodImpl] get; }

    public static extern DependencyProperty LayerProperty { [MethodImpl] get; }

    public static extern DependencyProperty ZoomLevelRangeProperty { [MethodImpl] get; }

    public static extern DependencyProperty BoundsProperty { [MethodImpl] get; }

    public static extern DependencyProperty AllowOverstretchProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsFadingEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsTransparencyEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsRetryEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty ZIndexProperty { [MethodImpl] get; }

    public static extern DependencyProperty TilePixelSizeProperty { [MethodImpl] get; }

    public static extern DependencyProperty VisibleProperty { [MethodImpl] get; }
  }
}
