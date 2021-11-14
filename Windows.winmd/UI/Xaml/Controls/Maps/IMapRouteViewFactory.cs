// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapRouteViewFactory
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
  [Guid(4035161567, 102, 17960, 130, 254, 234, 120, 194, 60, 236, 30)]
  internal interface IMapRouteViewFactory
  {
    MapRouteView CreateInstanceWithMapRoute(
      MapRoute route,
      object outer,
      out object inner);
  }
}
