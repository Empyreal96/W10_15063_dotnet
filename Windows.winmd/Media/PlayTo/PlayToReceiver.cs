// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.PlayToReceiver
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class PlayToReceiver : IPlayToReceiver
  {
    [MethodImpl]
    public extern PlayToReceiver();

    public extern event TypedEventHandler<PlayToReceiver, object> PlayRequested;

    public extern event TypedEventHandler<PlayToReceiver, object> PauseRequested;

    public extern event TypedEventHandler<PlayToReceiver, SourceChangeRequestedEventArgs> SourceChangeRequested;

    public extern event TypedEventHandler<PlayToReceiver, PlaybackRateChangeRequestedEventArgs> PlaybackRateChangeRequested;

    public extern event TypedEventHandler<PlayToReceiver, CurrentTimeChangeRequestedEventArgs> CurrentTimeChangeRequested;

    public extern event TypedEventHandler<PlayToReceiver, MuteChangeRequestedEventArgs> MuteChangeRequested;

    public extern event TypedEventHandler<PlayToReceiver, VolumeChangeRequestedEventArgs> VolumeChangeRequested;

    public extern event TypedEventHandler<PlayToReceiver, object> TimeUpdateRequested;

    public extern event TypedEventHandler<PlayToReceiver, object> StopRequested;

    [MethodImpl]
    public extern void NotifyVolumeChange(double volume, bool mute);

    [MethodImpl]
    public extern void NotifyRateChange(double rate);

    [MethodImpl]
    public extern void NotifyLoadedMetadata();

    [MethodImpl]
    public extern void NotifyTimeUpdate(TimeSpan currentTime);

    [MethodImpl]
    public extern void NotifyDurationChange(TimeSpan duration);

    [MethodImpl]
    public extern void NotifySeeking();

    [MethodImpl]
    public extern void NotifySeeked();

    [MethodImpl]
    public extern void NotifyPaused();

    [MethodImpl]
    public extern void NotifyPlaying();

    [MethodImpl]
    public extern void NotifyEnded();

    [MethodImpl]
    public extern void NotifyError();

    [MethodImpl]
    public extern void NotifyStopped();

    public extern string FriendlyName { [MethodImpl] get; [MethodImpl] set; }

    public extern bool SupportsImage { [MethodImpl] set; [MethodImpl] get; }

    public extern bool SupportsAudio { [MethodImpl] set; [MethodImpl] get; }

    public extern bool SupportsVideo { [MethodImpl] set; [MethodImpl] get; }

    public extern IPropertySet Properties { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StartAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StopAsync();
  }
}
