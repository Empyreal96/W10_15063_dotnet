// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.AudioProperties
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Static(typeof (IAudioPropertiesStatics), 100859904)]
  [Threading(ThreadingModel.Both)]
  [Version(100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class AudioProperties
  {
    public static extern string Name { [MethodImpl] get; }

    public static extern string Description { [MethodImpl] get; }

    public static extern string AlbumTrackIndex { [MethodImpl] get; }

    public static extern string Duration { [MethodImpl] get; }

    public static extern string AlbumId { [MethodImpl] get; }

    public static extern string ArtistId { [MethodImpl] get; }

    public static extern string AlbumName { [MethodImpl] get; }

    public static extern string ArtistName { [MethodImpl] get; }

    public static extern string GenreId { [MethodImpl] get; }

    public static extern string PodcastSeriesId { [MethodImpl] get; }

    public static extern string ThumbnailLargeUrl { [MethodImpl] get; }

    public static extern string MediaId { [MethodImpl] get; }

    public static extern string StorageLocation { [MethodImpl] get; }

    public static extern string Type { [MethodImpl] get; }

    public static extern string IsDrm { [MethodImpl] get; }

    public static extern string FilePath { [MethodImpl] get; }

    public static extern string FileSize { [MethodImpl] get; }

    public static extern string FormatCode { [MethodImpl] get; }

    public static extern string Uri { [MethodImpl] get; }

    public static extern string Date { [MethodImpl] get; }

    public static extern string Rating { [MethodImpl] get; }

    public static extern string DownloadState { [MethodImpl] get; }

    public static extern string DownloadType { [MethodImpl] get; }

    public static extern string InCollection { [MethodImpl] get; }

    public static extern string IsDisabled { [MethodImpl] get; }

    public static extern string PlayCount { [MethodImpl] get; }

    public static extern string DatePlayed { [MethodImpl] get; }

    public static extern string DateFavorite { [MethodImpl] get; }

    public static extern string DateAdded { [MethodImpl] get; }

    public static extern string MediaRights { [MethodImpl] get; }

    public static extern string ActionableId { [MethodImpl] get; }

    public static extern string LegacyId { [MethodImpl] get; }

    public static extern string IsAcquiredItem { [MethodImpl] get; }

    public static extern string Bookmark { [MethodImpl] get; }
  }
}
