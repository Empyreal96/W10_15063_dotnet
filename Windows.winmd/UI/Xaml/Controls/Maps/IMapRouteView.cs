// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapRouteView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Services.Maps;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ExclusiveTo(typeof (MapRouteView))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1947119301, 47820, 16865, 166, 126, 221, 101, 19, 131, 32, 73)]
  internal interface IMapRouteView
  {
    Color RouteColor { get; set; }

    Color OutlineColor { get; set; }

    MapRoute Route { get; }
  }
}
