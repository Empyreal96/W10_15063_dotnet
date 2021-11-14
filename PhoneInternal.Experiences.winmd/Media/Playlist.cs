// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.Playlist
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Version(100859904)]
  public sealed class Playlist : IMediaItem, IPlaylist
  {
    public extern string Id { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetExtraProperties(IIterable<IKeyValuePair<string, object>> props);

    [MethodImpl]
    public extern IAsyncOperation<IMap<string, object>> GetExtraPropertiesAsync(
      IIterable<string> propNames);

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    public extern uint LegacyId { [MethodImpl] get; }

    public extern bool AutoDownload { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    [MethodImpl]
    public extern IAsyncAction SaveAsync();

    [Overload("GetTracksQuery")]
    [MethodImpl]
    public extern AudioQueryResult GetTracksQuery();

    [Overload("GetTracksQueryEx")]
    [MethodImpl]
    public extern AudioQueryResult GetTracksQuery(
      StorageLocationFilter storageFilter);

    [MethodImpl]
    public extern IAsyncAction SetTracksAsync(IIterable<Audio> tracks);

    [MethodImpl]
    public extern IAsyncAction AppendTrackAsync(string itemId, Guid playlistEntryId);

    [MethodImpl]
    public extern IAsyncAction RemoveTrackAsync(Guid playlistEntryId);

    [MethodImpl]
    public extern IAsyncAction MoveTrackAsync(Guid itemToMoveId, Guid insertAfterItemId);

    [MethodImpl]
    public extern IAsyncAction ClearTracksAsync();
  }
}
