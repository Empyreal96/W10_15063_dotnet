// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IPlaybackMediaMarkerReachedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PlaybackMediaMarkerReachedEventArgs))]
  [Guid(1468846521, 37090, 20064, 171, 196, 135, 64, 176, 31, 97, 150)]
  internal interface IPlaybackMediaMarkerReachedEventArgs
  {
    PlaybackMediaMarker PlaybackMediaMarker { get; }
  }
}
