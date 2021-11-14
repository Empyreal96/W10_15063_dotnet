// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackCommandManagerRateReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlaybackCommandManagerRateReceivedEventArgs))]
  [Guid(418003257, 18966, 16745, 139, 5, 62, 185, 245, 255, 120, 235)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaPlaybackCommandManagerRateReceivedEventArgs
  {
    bool Handled { get; set; }

    double PlaybackRate { get; }

    Deferral GetDeferral();
  }
}
