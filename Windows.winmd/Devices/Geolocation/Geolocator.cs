// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geolocator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [Muse(Version = 100859904)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IGeolocatorStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IGeolocatorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Geolocator : IGeolocator, IGeolocatorWithScalarAccuracy, IGeolocator2
  {
    [MethodImpl]
    public extern Geolocator();

    public extern PositionAccuracy DesiredAccuracy { [MethodImpl] get; [MethodImpl] set; }

    public extern double MovementThreshold { [MethodImpl] get; [MethodImpl] set; }

    public extern uint ReportInterval { [MethodImpl] get; [MethodImpl] set; }

    public extern PositionStatus LocationStatus { [MethodImpl] get; }

    [RemoteAsync]
    [Overload("GetGeopositionAsync")]
    [MethodImpl]
    public extern IAsyncOperation<Geoposition> GetGeopositionAsync();

    [Overload("GetGeopositionAsyncWithAgeAndTimeout")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Geoposition> GetGeopositionAsync(
      TimeSpan maximumAge,
      TimeSpan timeout);

    public extern event TypedEventHandler<Geolocator, PositionChangedEventArgs> PositionChanged;

    public extern event TypedEventHandler<Geolocator, StatusChangedEventArgs> StatusChanged;

    public extern IReference<uint> DesiredAccuracyInMeters { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void AllowFallbackToConsentlessPositions();

    public static extern bool IsDefaultGeopositionRecommended { [MethodImpl] get; }

    public static extern IReference<BasicGeoposition> DefaultGeoposition { [MethodImpl] set; [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<GeolocationAccessStatus> RequestAccessAsync();

    [RemoteAsync]
    [Overload("GetGeopositionHistoryAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<Geoposition>> GetGeopositionHistoryAsync(
      DateTime startTime);

    [RemoteAsync]
    [Overload("GetGeopositionHistoryWithDurationAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<Geoposition>> GetGeopositionHistoryAsync(
      DateTime startTime,
      TimeSpan duration);
  }
}
