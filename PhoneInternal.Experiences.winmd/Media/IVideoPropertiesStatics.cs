// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IVideoPropertiesStatics
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Version(100859904)]
  [ExclusiveTo(typeof (VideoProperties))]
  [Guid(3862855457, 16976, 13165, 138, 1, 135, 69, 130, 124, 126, 193)]
  internal interface IVideoPropertiesStatics
  {
    string Name { get; }

    string Description { get; }

    string Duration { get; }

    string Width { get; }

    string Height { get; }

    string BitRate { get; }

    string FrameRate { get; }

    string StorageLocation { get; }

    string Type { get; }

    string PodcastSeriesId { get; }

    string ThumbnailSmallPath { get; }

    string ThumbnailSmallUrl { get; }

    string ThumbnailLargePath { get; }

    string ThumbnailLargeUrl { get; }

    string ContentUrl { get; }

    string PictureAlbumId { get; }

    string FilePath { get; }

    string FileSize { get; }

    string DownloadState { get; }

    string DownloadType { get; }

    string PlayCount { get; }

    string FormatCode { get; }

    string Rating { get; }

    string RemoteId { get; }

    string CreationTime { get; }

    string DateAdded { get; }

    string CaptureAppId { get; }

    string PersistentUniqueId { get; }

    string LegacyId { get; }

    string IsAcquiredItem { get; }

    string Bookmark { get; }
  }
}
