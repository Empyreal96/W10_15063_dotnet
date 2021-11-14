// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapStyleSheetStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ExclusiveTo(typeof (MapStyleSheet))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2881290413, 2588, 17205, 130, 244, 97, 217, 54, 170, 25, 125)]
  internal interface IMapStyleSheetStatics
  {
    MapStyleSheet Aerial();

    MapStyleSheet AerialWithOverlay();

    MapStyleSheet RoadLight();

    MapStyleSheet RoadDark();

    MapStyleSheet RoadHighContrastLight();

    MapStyleSheet RoadHighContrastDark();

    MapStyleSheet Combine(IIterable<MapStyleSheet> styleSheets);

    MapStyleSheet ParseFromJson(string styleAsJson);

    bool TryParseFromJson(string styleAsJson, out MapStyleSheet styleSheet);
  }
}
