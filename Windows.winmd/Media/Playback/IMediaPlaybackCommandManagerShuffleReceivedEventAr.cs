// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackCommandManagerShuffleReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Guid(1352686831, 25582, 19094, 183, 181, 254, 224, 139, 159, 249, 12)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaPlaybackCommandManagerShuffleReceivedEventArgs))]
  internal interface IMediaPlaybackCommandManagerShuffleReceivedEventArgs
  {
    bool Handled { get; set; }

    bool IsShuffleRequested { get; }

    Deferral GetDeferral();
  }
}
