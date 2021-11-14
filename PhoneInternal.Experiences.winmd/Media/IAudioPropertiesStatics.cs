// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IAudioPropertiesStatics
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [ExclusiveTo(typeof (AudioProperties))]
  [Guid(1360393300, 17524, 13175, 179, 115, 153, 78, 231, 15, 158, 85)]
  [Version(100859904)]
  internal interface IAudioPropertiesStatics
  {
    string Name { get; }

    string Description { get; }

    string AlbumTrackIndex { get; }

    string Duration { get; }

    string AlbumId { get; }

    string ArtistId { get; }

    string AlbumName { get; }

    string ArtistName { get; }

    string GenreId { get; }

    string PodcastSeriesId { get; }

    string ThumbnailLargeUrl { get; }

    string MediaId { get; }

    string StorageLocation { get; }

    string Type { get; }

    string IsDrm { get; }

    string FilePath { get; }

    string FileSize { get; }

    string FormatCode { get; }

    string Uri { get; }

    string Date { get; }

    string Rating { get; }

    string DownloadState { get; }

    string DownloadType { get; }

    string InCollection { get; }

    string IsDisabled { get; }

    string PlayCount { get; }

    string DatePlayed { get; }

    string DateFavorite { get; }

    string DateAdded { get; }

    string MediaRights { get; }

    string ActionableId { get; }

    string LegacyId { get; }

    string IsAcquiredItem { get; }

    string Bookmark { get; }
  }
}
