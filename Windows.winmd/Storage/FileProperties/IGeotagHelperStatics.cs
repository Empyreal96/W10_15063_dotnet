// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.IGeotagHelperStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1095316036, 9508, 18005, 134, 166, 237, 22, 245, 252, 113, 107)]
  [ExclusiveTo(typeof (GeotagHelper))]
  internal interface IGeotagHelperStatics
  {
    [RemoteAsync]
    IAsyncOperation<Geopoint> GetGeotagAsync(IStorageFile file);

    [RemoteAsync]
    IAsyncAction SetGeotagFromGeolocatorAsync(IStorageFile file, Geolocator geolocator);

    [RemoteAsync]
    IAsyncAction SetGeotagAsync(IStorageFile file, Geopoint geopoint);
  }
}
