// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayer2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlayer))]
  [Guid(1015288344, 8483, 20421, 144, 130, 47, 136, 63, 119, 189, 245)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaPlayer2
  {
    SystemMediaTransportControls SystemMediaTransportControls { get; }

    MediaPlayerAudioCategory AudioCategory { get; set; }

    MediaPlayerAudioDeviceType AudioDeviceType { get; set; }
  }
}
