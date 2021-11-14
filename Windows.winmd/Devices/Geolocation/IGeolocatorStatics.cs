// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeolocatorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [Guid(2593027441, 11765, 17809, 159, 135, 235, 95, 216, 148, 233, 183)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Geolocator))]
  internal interface IGeolocatorStatics
  {
    [RemoteAsync]
    IAsyncOperation<GeolocationAccessStatus> RequestAccessAsync();

    [Overload("GetGeopositionHistoryAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<Geoposition>> GetGeopositionHistoryAsync(
      DateTime startTime);

    [RemoteAsync]
    [Overload("GetGeopositionHistoryWithDurationAsync")]
    IAsyncOperation<IVectorView<Geoposition>> GetGeopositionHistoryAsync(
      DateTime startTime,
      TimeSpan duration);
  }
}
