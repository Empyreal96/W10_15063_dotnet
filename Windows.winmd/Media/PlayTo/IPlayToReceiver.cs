// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IPlayToReceiver
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [ExclusiveTo(typeof (PlayToReceiver))]
  [Guid(2887110471, 41314, 19110, 175, 27, 58, 163, 95, 59, 144, 105)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPlayToReceiver
  {
    event TypedEventHandler<PlayToReceiver, object> PlayRequested;

    event TypedEventHandler<PlayToReceiver, object> PauseRequested;

    event TypedEventHandler<PlayToReceiver, SourceChangeRequestedEventArgs> SourceChangeRequested;

    event TypedEventHandler<PlayToReceiver, PlaybackRateChangeRequestedEventArgs> PlaybackRateChangeRequested;

    event TypedEventHandler<PlayToReceiver, CurrentTimeChangeRequestedEventArgs> CurrentTimeChangeRequested;

    event TypedEventHandler<PlayToReceiver, MuteChangeRequestedEventArgs> MuteChangeRequested;

    event TypedEventHandler<PlayToReceiver, VolumeChangeRequestedEventArgs> VolumeChangeRequested;

    event TypedEventHandler<PlayToReceiver, object> TimeUpdateRequested;

    event TypedEventHandler<PlayToReceiver, object> StopRequested;

    void NotifyVolumeChange(double volume, bool mute);

    void NotifyRateChange(double rate);

    void NotifyLoadedMetadata();

    void NotifyTimeUpdate(TimeSpan currentTime);

    void NotifyDurationChange(TimeSpan duration);

    void NotifySeeking();

    void NotifySeeked();

    void NotifyPaused();

    void NotifyPlaying();

    void NotifyEnded();

    void NotifyError();

    void NotifyStopped();

    string FriendlyName { get; set; }

    bool SupportsImage { set; get; }

    bool SupportsAudio { set; get; }

    bool SupportsVideo { set; get; }

    IPropertySet Properties { get; }

    [RemoteAsync]
    IAsyncAction StartAsync();

    [RemoteAsync]
    IAsyncAction StopAsync();
  }
}
