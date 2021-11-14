// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.MediaPlayerPresenter
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
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Composable(typeof (IMediaPlayerPresenterFactory), CompositionType.Public, 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMediaPlayerPresenterStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class MediaPlayerPresenter : FrameworkElement, IMediaPlayerPresenter
  {
    [MethodImpl]
    public extern MediaPlayerPresenter();

    public extern MediaPlayer MediaPlayer { [MethodImpl] get; [MethodImpl] set; }

    public extern Stretch Stretch { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsFullWindow { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty MediaPlayerProperty { [MethodImpl] get; }

    public static extern DependencyProperty StretchProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsFullWindowProperty { [MethodImpl] get; }
  }
}
