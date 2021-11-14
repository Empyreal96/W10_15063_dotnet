// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackVideoTrackList
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
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MediaPlaybackVideoTrackList : 
    IVectorView<VideoTrack>,
    IIterable<VideoTrack>,
    ISingleSelectMediaTrackList
  {
    [MethodImpl]
    public extern VideoTrack GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IndexOf(VideoTrack value, out uint index);

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] VideoTrack[] items);

    [MethodImpl]
    public extern IIterator<VideoTrack> First();

    public extern event TypedEventHandler<ISingleSelectMediaTrackList, object> SelectedIndexChanged;

    public extern int SelectedIndex { [MethodImpl] set; [MethodImpl] get; }
  }
}
