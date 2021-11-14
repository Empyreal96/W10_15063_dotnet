// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaPlayerElement
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Playback;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaPlayerElement))]
  [Guid(994878758, 11813, 17816, 188, 113, 212, 145, 248, 232, 222, 57)]
  internal interface IMediaPlayerElement
  {
    IMediaPlaybackSource Source { get; set; }

    MediaTransportControls TransportControls { get; set; }

    bool AreTransportControlsEnabled { get; set; }

    ImageSource PosterSource { get; set; }

    Stretch Stretch { get; set; }

    bool AutoPlay { get; set; }

    bool IsFullWindow { get; set; }

    MediaPlayer MediaPlayer { get; }

    void SetMediaPlayer(MediaPlayer mediaPlayer);
  }
}
