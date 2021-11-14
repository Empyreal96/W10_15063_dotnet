// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.StreetsidePanorama
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IStreetsidePanoramaStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class StreetsidePanorama : DependencyObject, IStreetsidePanorama
  {
    public extern Geopoint Location { [MethodImpl] get; }

    [Overload("FindNearbyWithLocationAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StreetsidePanorama> FindNearbyAsync(
      Geopoint location);

    [RemoteAsync]
    [Overload("FindNearbyWithLocationAndRadiusAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<StreetsidePanorama> FindNearbyAsync(
      Geopoint location,
      double radiusInMeters);
  }
}
