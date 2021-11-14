// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.MediaPlayerElement
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Playback;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Composable(typeof (IMediaPlayerElementFactory), CompositionType.Public, 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMediaPlayerElementStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public class MediaPlayerElement : Control, IMediaPlayerElement
  {
    [MethodImpl]
    public extern MediaPlayerElement();

    public extern IMediaPlaybackSource Source { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaTransportControls TransportControls { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AreTransportControlsEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern ImageSource PosterSource { [MethodImpl] get; [MethodImpl] set; }

    public extern Stretch Stretch { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AutoPlay { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsFullWindow { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaPlayer MediaPlayer { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetMediaPlayer(MediaPlayer mediaPlayer);

    public static extern DependencyProperty SourceProperty { [MethodImpl] get; }

    public static extern DependencyProperty AreTransportControlsEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty PosterSourceProperty { [MethodImpl] get; }

    public static extern DependencyProperty StretchProperty { [MethodImpl] get; }

    public static extern DependencyProperty AutoPlayProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsFullWindowProperty { [MethodImpl] get; }

    public static extern DependencyProperty MediaPlayerProperty { [MethodImpl] get; }
  }
}
