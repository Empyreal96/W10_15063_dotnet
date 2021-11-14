// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IPicturePropertiesStatics
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Guid(1835271125, 56813, 15438, 130, 188, 175, 63, 221, 137, 72, 152)]
  [ExclusiveTo(typeof (PictureProperties))]
  [Version(100859904)]
  internal interface IPicturePropertiesStatics
  {
    string Name { get; }

    string Description { get; }

    string Width { get; }

    string Height { get; }

    string ThumbnailSmallPath { get; }

    string ThumbnailSmallUrl { get; }

    string ThumbnailLargePath { get; }

    string ThumbnailLargeUrl { get; }

    string ContentUrl { get; }

    string PictureAlbumId { get; }

    string StorageLocation { get; }

    string FilePath { get; }

    string FormatCode { get; }

    string Orientation { get; }

    string Latitude { get; }

    string Longitude { get; }

    string Altitude { get; }

    string Heading { get; }

    string CreationTime { get; }

    string RemoteId { get; }

    string CaptureAppId { get; }

    string Rating { get; }

    string PersistentUniqueId { get; }

    string LegacyId { get; }

    string IsAcquiredItem { get; }
  }
}
