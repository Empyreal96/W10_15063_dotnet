// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1030704931, 21040, 17425, 160, 233, 186, 217, 76, 42, 4, 92)]
  [ExclusiveTo(typeof (MediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs))]
  internal interface IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs
  {
    bool Handled { get; set; }

    MediaPlaybackAutoRepeatMode AutoRepeatMode { get; }

    Deferral GetDeferral();
  }
}
