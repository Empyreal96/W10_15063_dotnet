// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackItemFactory2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlaybackItem))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3615285050, 47431, 18802, 179, 93, 173, 251, 147, 26, 113, 230)]
  internal interface IMediaPlaybackItemFactory2 : IMediaPlaybackItemFactory
  {
    MediaPlaybackItem CreateWithStartTime(MediaSource source, TimeSpan startTime);

    MediaPlaybackItem CreateWithStartTimeAndDurationLimit(
      MediaSource source,
      TimeSpan startTime,
      TimeSpan durationLimit);
  }
}
