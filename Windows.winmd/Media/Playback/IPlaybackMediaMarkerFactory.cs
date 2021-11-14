// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IPlaybackMediaMarkerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Guid(2354252408, 57518, 19994, 168, 200, 226, 63, 152, 42, 147, 123)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PlaybackMediaMarker))]
  internal interface IPlaybackMediaMarkerFactory
  {
    PlaybackMediaMarker CreateFromTime(TimeSpan value);

    PlaybackMediaMarker Create(
      TimeSpan value,
      string mediaMarketType,
      string text);
  }
}
