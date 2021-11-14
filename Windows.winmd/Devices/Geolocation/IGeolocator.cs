// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeolocator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [Guid(2848178018, 17700, 18825, 138, 169, 222, 1, 157, 46, 85, 31)]
  [ExclusiveTo(typeof (Geolocator))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGeolocator
  {
    PositionAccuracy DesiredAccuracy { get; set; }

    double MovementThreshold { get; set; }

    uint ReportInterval { get; set; }

    PositionStatus LocationStatus { get; }

    [RemoteAsync]
    [Overload("GetGeopositionAsync")]
    IAsyncOperation<Geoposition> GetGeopositionAsync();

    [Overload("GetGeopositionAsyncWithAgeAndTimeout")]
    [RemoteAsync]
    IAsyncOperation<Geoposition> GetGeopositionAsync(
      TimeSpan maximumAge,
      TimeSpan timeout);

    event TypedEventHandler<Geolocator, PositionChangedEventArgs> PositionChanged;

    event TypedEventHandler<Geolocator, StatusChangedEventArgs> StatusChanged;
  }
}
