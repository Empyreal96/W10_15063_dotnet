// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackCommandManagerPauseReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Guid(1559022876, 49756, 16929, 177, 108, 195, 201, 140, 224, 18, 214)]
  [ExclusiveTo(typeof (MediaPlaybackCommandManagerPauseReceivedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaPlaybackCommandManagerPauseReceivedEventArgs
  {
    bool Handled { get; set; }

    Deferral GetDeferral();
  }
}
