// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackList
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Guid(2138566300, 56386, 20006, 169, 141, 120, 80, 223, 142, 201, 37)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaPlaybackList))]
  internal interface IMediaPlaybackList : IMediaPlaybackSource
  {
    event TypedEventHandler<MediaPlaybackList, MediaPlaybackItemFailedEventArgs> ItemFailed;

    event TypedEventHandler<MediaPlaybackList, CurrentMediaPlaybackItemChangedEventArgs> CurrentItemChanged;

    event TypedEventHandler<MediaPlaybackList, MediaPlaybackItemOpenedEventArgs> ItemOpened;

    IObservableVector<MediaPlaybackItem> Items { get; }

    bool AutoRepeatEnabled { get; set; }

    bool ShuffleEnabled { get; set; }

    MediaPlaybackItem CurrentItem { get; }

    uint CurrentItemIndex { get; }

    MediaPlaybackItem MoveNext();

    MediaPlaybackItem MovePrevious();

    MediaPlaybackItem MoveTo(uint itemIndex);
  }
}
