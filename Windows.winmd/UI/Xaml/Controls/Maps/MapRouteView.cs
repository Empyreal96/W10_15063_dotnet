// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapRouteView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Services.Maps;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Composable(typeof (IMapRouteViewFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class MapRouteView : DependencyObject, IMapRouteView
  {
    [MethodImpl]
    public extern MapRouteView(MapRoute route);

    public extern Color RouteColor { [MethodImpl] get; [MethodImpl] set; }

    public extern Color OutlineColor { [MethodImpl] get; [MethodImpl] set; }

    public extern MapRoute Route { [MethodImpl] get; }
  }
}
