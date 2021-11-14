// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IPlaylist
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Guid(3234405289, 6909, 15860, 145, 150, 157, 0, 90, 106, 162, 190)]
  [Version(100859904)]
  [ExclusiveTo(typeof (Playlist))]
  internal interface IPlaylist : IMediaItem
  {
    string Name { get; set; }

    uint LegacyId { get; }

    bool AutoDownload { get; set; }

    IAsyncAction DeleteAsync();

    IAsyncAction SaveAsync();

    [Overload("GetTracksQuery")]
    AudioQueryResult GetTracksQuery();

    [Overload("GetTracksQueryEx")]
    AudioQueryResult GetTracksQuery(StorageLocationFilter storageFilter);

    IAsyncAction SetTracksAsync(IIterable<Audio> tracks);

    IAsyncAction AppendTrackAsync(string itemId, Guid playlistEntryId);

    IAsyncAction RemoveTrackAsync(Guid playlistEntryId);

    IAsyncAction MoveTrackAsync(Guid itemToMoveId, Guid insertAfterItemId);

    IAsyncAction ClearTracksAsync();
  }
}
