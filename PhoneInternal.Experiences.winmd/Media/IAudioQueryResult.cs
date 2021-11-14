// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IAudioQueryResult
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace PhoneInternal.Experiences.Media
{
  [Guid(739328808, 23456, 13903, 185, 98, 40, 47, 42, 158, 86, 59)]
  [Version(100859904)]
  [ExclusiveTo(typeof (AudioQueryResult))]
  internal interface IAudioQueryResult
  {
    IVector<string> FetchProperties { get; }

    IVector<string> FetchExtraProperties { get; }

    IAsyncOperation<uint> GetTrackCountAsync();

    [Overload("GetTracksAsync")]
    IAsyncOperation<IVector<Audio>> GetTracksAsync();

    [Overload("GetTracksAsyncEx")]
    IAsyncOperation<IVector<Audio>> GetTracksAsync(int count);

    IAsyncAction MoveLastAsync();

    IAsyncOperation<IVector<short>> GetSortGroupsAsync();

    AudioQueryResult GetSortGroupQuery(short groupId);

    IAsyncOperation<Buffer> GetBookmarkAsync();

    IAsyncAction MoveToBookmarkAsync(Buffer pPosition);
  }
}
