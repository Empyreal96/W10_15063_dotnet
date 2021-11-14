// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapTileSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ExclusiveTo(typeof (MapTileSource))]
  [WebHostHidden]
  [Guid(2292674126, 12255, 17767, 146, 85, 17, 0, 81, 156, 141, 98)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMapTileSource
  {
    MapTileDataSource DataSource { get; set; }

    MapTileLayer Layer { get; set; }

    MapZoomLevelRange ZoomLevelRange { get; set; }

    GeoboundingBox Bounds { get; set; }

    bool AllowOverstretch { get; set; }

    bool IsFadingEnabled { get; set; }

    bool IsTransparencyEnabled { get; set; }

    bool IsRetryEnabled { get; set; }

    int ZIndex { get; set; }

    int TilePixelSize { get; set; }

    bool Visible { get; set; }
  }
}
