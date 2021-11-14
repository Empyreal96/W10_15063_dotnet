// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.IGuidanceNavigator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [ExclusiveTo(typeof (GuidanceNavigator))]
  [ContractVersion(typeof (GuidanceContract), 65536)]
  [Guid(150044407, 36415, 19866, 190, 138, 16, 143, 154, 1, 44, 103)]
  [WebHostHidden]
  internal interface IGuidanceNavigator
  {
    void StartNavigating(GuidanceRoute route);

    void StartSimulating(GuidanceRoute route, int speedInMetersPerSecond);

    void StartTracking();

    void Pause();

    void Resume();

    void Stop();

    void RepeatLastAudioNotification();

    GuidanceAudioMeasurementSystem AudioMeasurementSystem { get; set; }

    GuidanceAudioNotifications AudioNotifications { get; set; }

    event TypedEventHandler<GuidanceNavigator, GuidanceUpdatedEventArgs> GuidanceUpdated;

    event TypedEventHandler<GuidanceNavigator, object> DestinationReached;

    event TypedEventHandler<GuidanceNavigator, object> Rerouting;

    event TypedEventHandler<GuidanceNavigator, GuidanceReroutedEventArgs> Rerouted;

    event TypedEventHandler<GuidanceNavigator, object> RerouteFailed;

    event TypedEventHandler<GuidanceNavigator, object> UserLocationLost;

    event TypedEventHandler<GuidanceNavigator, object> UserLocationRestored;

    void SetGuidanceVoice(int voiceId, string voiceFolder);

    [Overload("UpdateUserLocation")]
    void UpdateUserLocation(Geocoordinate userLocation);

    [Overload("UpdateUserLocationWithPositionOverride")]
    void UpdateUserLocation(Geocoordinate userLocation, BasicGeoposition positionOverride);
  }
}
