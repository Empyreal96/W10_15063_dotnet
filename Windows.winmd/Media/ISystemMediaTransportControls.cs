// Decompiled with JetBrains decompiler
// Type: Windows.Media.ISystemMediaTransportControls
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ExclusiveTo(typeof (SystemMediaTransportControls))]
  [Guid(2583314420, 5954, 17062, 144, 46, 8, 125, 65, 249, 101, 236)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISystemMediaTransportControls
  {
    MediaPlaybackStatus PlaybackStatus { get; set; }

    SystemMediaTransportControlsDisplayUpdater DisplayUpdater { get; }

    SoundLevel SoundLevel { get; }

    bool IsEnabled { get; set; }

    bool IsPlayEnabled { get; set; }

    bool IsStopEnabled { get; set; }

    bool IsPauseEnabled { get; set; }

    bool IsRecordEnabled { get; set; }

    bool IsFastForwardEnabled { get; set; }

    bool IsRewindEnabled { get; set; }

    bool IsPreviousEnabled { get; set; }

    bool IsNextEnabled { get; set; }

    bool IsChannelUpEnabled { get; set; }

    bool IsChannelDownEnabled { get; set; }

    event TypedEventHandler<SystemMediaTransportControls, SystemMediaTransportControlsButtonPressedEventArgs> ButtonPressed;

    event TypedEventHandler<SystemMediaTransportControls, SystemMediaTransportControlsPropertyChangedEventArgs> PropertyChanged;
  }
}
