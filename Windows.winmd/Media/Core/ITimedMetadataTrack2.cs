// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedMetadataTrack2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Playback;

namespace Windows.Media.Core
{
  [Guid(565491272, 40861, 16570, 168, 243, 26, 146, 117, 58, 239, 11)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (TimedMetadataTrack))]
  internal interface ITimedMetadataTrack2 : ITimedMetadataTrack, IMediaTrack
  {
    MediaPlaybackItem PlaybackItem { get; }

    string Name { get; }
  }
}
