// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaItemDisplayProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaItemDisplayProperties))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(507255624, 28823, 17284, 162, 23, 193, 41, 29, 250, 140, 22)]
  internal interface IMediaItemDisplayProperties
  {
    MediaPlaybackType Type { get; set; }

    MusicDisplayProperties MusicProperties { get; }

    VideoDisplayProperties VideoProperties { get; }

    RandomAccessStreamReference Thumbnail { get; set; }

    void ClearAll();
  }
}
