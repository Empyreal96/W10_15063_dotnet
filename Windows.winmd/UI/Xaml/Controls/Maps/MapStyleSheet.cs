// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapStyleSheet
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMapStyleSheetStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MapStyleSheet : DependencyObject, IMapStyleSheet
  {
    [MethodImpl]
    public static extern MapStyleSheet Aerial();

    [MethodImpl]
    public static extern MapStyleSheet AerialWithOverlay();

    [MethodImpl]
    public static extern MapStyleSheet RoadLight();

    [MethodImpl]
    public static extern MapStyleSheet RoadDark();

    [MethodImpl]
    public static extern MapStyleSheet RoadHighContrastLight();

    [MethodImpl]
    public static extern MapStyleSheet RoadHighContrastDark();

    [MethodImpl]
    public static extern MapStyleSheet Combine(IIterable<MapStyleSheet> styleSheets);

    [MethodImpl]
    public static extern MapStyleSheet ParseFromJson(string styleAsJson);

    [MethodImpl]
    public static extern bool TryParseFromJson(string styleAsJson, out MapStyleSheet styleSheet);
  }
}
