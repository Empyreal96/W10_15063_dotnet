// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IPlaybackMediaMarkerSequence
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Guid(4068543726, 25483, 18127, 136, 23, 29, 17, 31, 233, 216, 196)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PlaybackMediaMarkerSequence))]
  internal interface IPlaybackMediaMarkerSequence : IIterable<PlaybackMediaMarker>
  {
    uint Size { get; }

    void Insert(PlaybackMediaMarker value);

    void Clear();
  }
}
