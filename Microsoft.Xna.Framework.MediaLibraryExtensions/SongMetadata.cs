// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Media.PhoneExtensions.SongMetadata
// Assembly: Microsoft.Xna.Framework.MediaLibraryExtensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 04C233BD-5657-44BB-8EEE-63321B92241D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIE731~1.DLL

using System;

namespace Microsoft.Xna.Framework.Media.PhoneExtensions
{
  public sealed class SongMetadata
  {
    public string Name { get; set; }

    public TimeSpan Duration { get; set; }

    public string ArtistName { get; set; }

    public string GenreName { get; set; }

    public string AlbumName { get; set; }

    public int TrackNumber { get; set; }

    public string AlbumArtistName { get; set; }

    public DateTime AlbumReleaseDate { get; set; }

    public Uri AlbumArtUri { get; set; }

    public Uri ArtistBackgroundUri { get; set; }

    public Uri AlbumArtistBackgroundUri { get; set; }
  }
}
