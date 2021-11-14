// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapControlTransitFeatureClickEventArgs
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
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(131072, "Windows.Services.Maps.LocalSearchContract")]
  [WebHostHidden]
  [ContractVersion(typeof (LocalSearchContract), 131072)]
  public sealed class MapControlTransitFeatureClickEventArgs : 
    IMapControlTransitFeatureClickEventArgs
  {
    [MethodImpl]
    public extern MapControlTransitFeatureClickEventArgs();

    public extern string DisplayName { [MethodImpl] get; }

    public extern Geopoint Location { [MethodImpl] get; }

    public extern IMapView<string, object> TransitProperties { [MethodImpl] get; }
  }
}
