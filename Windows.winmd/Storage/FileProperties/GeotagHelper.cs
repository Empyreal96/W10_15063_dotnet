// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.GeotagHelper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  [Static(typeof (IGeotagHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class GeotagHelper
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Geopoint> GetGeotagAsync(
      IStorageFile file);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction SetGeotagFromGeolocatorAsync(
      IStorageFile file,
      Geolocator geolocator);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction SetGeotagAsync(
      IStorageFile file,
      Geopoint geopoint);
  }
}
