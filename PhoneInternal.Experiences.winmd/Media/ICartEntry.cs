// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.ICartEntry
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace PhoneInternal.Experiences.Media
{
  [Version(100859904)]
  [Guid(550155604, 63120, 19438, 158, 186, 246, 9, 77, 214, 41, 210)]
  [ExclusiveTo(typeof (CartEntry))]
  internal interface ICartEntry : IMediaItem
  {
    string Name { get; set; }

    uint LegacyId { get; }

    Guid MediaId { get; set; }

    IRandomAccessStreamReference Thumbnail { get; set; }

    string DownloadInstanceId { get; set; }

    string DownloadLicenseType { get; set; }

    string EncodingType { get; set; }

    string OfferId { get; set; }

    uint AttemptCount { get; set; }

    uint LastError { get; set; }

    [Overload("LoadPropertiesAsync")]
    IAsyncAction LoadPropertiesAsync();

    [Overload("LoadPropertiesAsyncEx")]
    IAsyncAction LoadPropertiesAsync(IIterable<string> props);

    IAsyncAction DeleteAsync();

    IAsyncAction SaveAsync();
  }
}
