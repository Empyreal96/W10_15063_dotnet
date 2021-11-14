// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IGenre
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Guid(2411141848, 6467, 12865, 184, 81, 172, 194, 157, 175, 235, 244)]
  [Version(100859904)]
  [ExclusiveTo(typeof (Genre))]
  internal interface IGenre : IMediaItem
  {
    string Name { get; set; }

    uint LegacyId { get; }

    uint Count { get; }

    IAsyncAction DeleteAsync();

    IAsyncAction SaveAsync();

    [Overload("GetTracksQuery")]
    AudioQueryResult GetTracksQuery();

    [Overload("GetTracksQueryEx")]
    AudioQueryResult GetTracksQuery(StorageLocationFilter storageLocation);
  }
}
