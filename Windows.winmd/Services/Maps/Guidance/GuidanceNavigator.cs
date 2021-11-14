// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.GuidanceNavigator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [ContractVersion(typeof (GuidanceContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IGuidanceNavigatorStatics), 65536, "Windows.Services.Maps.GuidanceContract")]
  [WebHostHidden]
  [Static(typeof (IGuidanceNavigatorStatics2), 131072, "Windows.Services.Maps.GuidanceContract")]
  public sealed class GuidanceNavigator : IGuidanceNavigator, IGuidanceNavigator2
  {
    [MethodImpl]
    public extern void StartNavigating(GuidanceRoute route);

    [MethodImpl]
    public extern void StartSimulating(GuidanceRoute route, int speedInMetersPerSecond);

    [MethodImpl]
    public extern void StartTracking();

    [MethodImpl]
    public extern void Pause();

    [MethodImpl]
    public extern void Resume();

    [MethodImpl]
    public extern void Stop();

    [MethodImpl]
    public extern void RepeatLastAudioNotification();

    public extern GuidanceAudioMeasurementSystem AudioMeasurementSystem { [MethodImpl] get; [MethodImpl] set; }

    public extern GuidanceAudioNotifications AudioNotifications { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<GuidanceNavigator, GuidanceUpdatedEventArgs> GuidanceUpdated;

    public extern event TypedEventHandler<GuidanceNavigator, object> DestinationReached;

    public extern event TypedEventHandler<GuidanceNavigator, object> Rerouting;

    public extern event TypedEventHandler<GuidanceNavigator, GuidanceReroutedEventArgs> Rerouted;

    public extern event TypedEventHandler<GuidanceNavigator, object> RerouteFailed;

    public extern event TypedEventHandler<GuidanceNavigator, object> UserLocationLost;

    public extern event TypedEventHandler<GuidanceNavigator, object> UserLocationRestored;

    [MethodImpl]
    public extern void SetGuidanceVoice(int voiceId, string voiceFolder);

    [Overload("UpdateUserLocation")]
    [MethodImpl]
    public extern void UpdateUserLocation(Geocoordinate userLocation);

    [Overload("UpdateUserLocationWithPositionOverride")]
    [MethodImpl]
    public extern void UpdateUserLocation(
      Geocoordinate userLocation,
      BasicGeoposition positionOverride);

    public extern event TypedEventHandler<GuidanceNavigator, GuidanceAudioNotificationRequestedEventArgs> AudioNotificationRequested;

    public extern bool IsGuidanceAudioMuted { [MethodImpl] get; [MethodImpl] set; }

    public static extern bool UseAppProvidedVoice { [MethodImpl] get; }

    [MethodImpl]
    public static extern GuidanceNavigator GetCurrent();
  }
}
