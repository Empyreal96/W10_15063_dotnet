// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackTimedMetadataTrackList
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class MediaPlaybackTimedMetadataTrackList : 
    IVectorView<TimedMetadataTrack>,
    IIterable<TimedMetadataTrack>,
    IMediaPlaybackTimedMetadataTrackList
  {
    [MethodImpl]
    public extern TimedMetadataTrack GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IndexOf(TimedMetadataTrack value, out uint index);

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] TimedMetadataTrack[] items);

    [MethodImpl]
    public extern IIterator<TimedMetadataTrack> First();

    public extern event TypedEventHandler<MediaPlaybackTimedMetadataTrackList, TimedMetadataPresentationModeChangedEventArgs> PresentationModeChanged;

    [MethodImpl]
    public extern TimedMetadataTrackPresentationMode GetPresentationMode(
      uint index);

    [MethodImpl]
    public extern void SetPresentationMode(uint index, TimedMetadataTrackPresentationMode value);
  }
}
