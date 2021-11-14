// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackList
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaPlaybackList : 
    IMediaPlaybackList,
    IMediaPlaybackSource,
    IMediaPlaybackList2,
    IMediaPlaybackList3
  {
    [MethodImpl]
    public extern MediaPlaybackList();

    public extern event TypedEventHandler<MediaPlaybackList, MediaPlaybackItemFailedEventArgs> ItemFailed;

    public extern event TypedEventHandler<MediaPlaybackList, CurrentMediaPlaybackItemChangedEventArgs> CurrentItemChanged;

    public extern event TypedEventHandler<MediaPlaybackList, MediaPlaybackItemOpenedEventArgs> ItemOpened;

    public extern IObservableVector<MediaPlaybackItem> Items { [MethodImpl] get; }

    public extern bool AutoRepeatEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool ShuffleEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaPlaybackItem CurrentItem { [MethodImpl] get; }

    public extern uint CurrentItemIndex { [MethodImpl] get; }

    [MethodImpl]
    public extern MediaPlaybackItem MoveNext();

    [MethodImpl]
    public extern MediaPlaybackItem MovePrevious();

    [MethodImpl]
    public extern MediaPlaybackItem MoveTo(uint itemIndex);

    public extern IReference<TimeSpan> MaxPrefetchTime { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaPlaybackItem StartingItem { [MethodImpl] get; [MethodImpl] set; }

    public extern IVectorView<MediaPlaybackItem> ShuffledItems { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetShuffledItems(IIterable<MediaPlaybackItem> value);

    public extern IReference<uint> MaxPlayedItemsToKeepOpen { [MethodImpl] get; [MethodImpl] set; }
  }
}
