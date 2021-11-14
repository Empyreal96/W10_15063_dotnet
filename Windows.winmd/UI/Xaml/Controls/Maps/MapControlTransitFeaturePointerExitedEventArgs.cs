// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapControlTransitFeaturePointerExitedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Services.Maps;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (LocalSearchContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(196608, "Windows.Services.Maps.LocalSearchContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class MapControlTransitFeaturePointerExitedEventArgs : 
    IMapControlTransitFeaturePointerExitedEventArgs
  {
    [MethodImpl]
    public extern MapControlTransitFeaturePointerExitedEventArgs();

    public extern string DisplayName { [MethodImpl] get; }

    public extern Geopoint Location { [MethodImpl] get; }

    public extern IMapView<string, object> TransitProperties { [MethodImpl] get; }
  }
}
