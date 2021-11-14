// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IEvent
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Guid(254253185, 57027, 13820, 175, 31, 127, 133, 74, 24, 208, 43)]
  [ExclusiveTo(typeof (Event))]
  [Version(100859904)]
  internal interface IEvent : IMediaItem
  {
    string Name { get; set; }

    uint LegacyId { get; }

    string PictureAlbumId { get; }

    DateTime DateStart { get; }

    uint Count { get; }

    bool IsChanged { get; set; }

    bool IsLoose { get; set; }

    [Overload("LoadPropertiesAsync")]
    IAsyncAction LoadPropertiesAsync();

    [Overload("LoadPropertiesAsyncEx")]
    IAsyncAction LoadPropertiesAsync(IIterable<string> props);

    IAsyncAction DeleteAsync();

    IAsyncAction SaveAsync();

    [Overload("GetContentsQuery")]
    MediaItemQueryResult GetContentsQuery();
  }
}
