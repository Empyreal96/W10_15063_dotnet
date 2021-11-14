// Decompiled with JetBrains decompiler
// Type: Windows.Media.SystemMediaTransportControls
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Threading(ThreadingModel.MTA)]
  [Muse(Version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ISystemMediaTransportControlsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SystemMediaTransportControls : 
    ISystemMediaTransportControls,
    ISystemMediaTransportControls2
  {
    public extern MediaPlaybackStatus PlaybackStatus { [MethodImpl] get; [MethodImpl] set; }

    public extern SystemMediaTransportControlsDisplayUpdater DisplayUpdater { [MethodImpl] get; }

    public extern SoundLevel SoundLevel { [MethodImpl] get; }

    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsPlayEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsStopEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsPauseEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsRecordEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsFastForwardEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsRewindEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsPreviousEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsNextEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsChannelUpEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsChannelDownEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<SystemMediaTransportControls, SystemMediaTransportControlsButtonPressedEventArgs> ButtonPressed;

    public extern event TypedEventHandler<SystemMediaTransportControls, SystemMediaTransportControlsPropertyChangedEventArgs> PropertyChanged;

    public extern MediaPlaybackAutoRepeatMode AutoRepeatMode { [MethodImpl] get; [MethodImpl] set; }

    public extern bool ShuffleEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern double PlaybackRate { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void UpdateTimelineProperties(
      SystemMediaTransportControlsTimelineProperties timelineProperties);

    public extern event TypedEventHandler<SystemMediaTransportControls, PlaybackPositionChangeRequestedEventArgs> PlaybackPositionChangeRequested;

    public extern event TypedEventHandler<SystemMediaTransportControls, PlaybackRateChangeRequestedEventArgs> PlaybackRateChangeRequested;

    public extern event TypedEventHandler<SystemMediaTransportControls, ShuffleEnabledChangeRequestedEventArgs> ShuffleEnabledChangeRequested;

    public extern event TypedEventHandler<SystemMediaTransportControls, AutoRepeatModeChangeRequestedEventArgs> AutoRepeatModeChangeRequested;

    [MethodImpl]
    public static extern SystemMediaTransportControls GetForCurrentView();
  }
}
