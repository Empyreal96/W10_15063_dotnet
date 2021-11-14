// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Media.MediaLibrary
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Collections.Generic;
using System.IO;
using System.Security;

namespace Microsoft.Xna.Framework.Media
{
  public sealed class MediaLibrary : IDisposable
  {
    private static MediaFinalizerHelper mediaHelper;
    private SongCollection songs = SongCollection.Empty;
    private ArtistCollection artists = ArtistCollection.Empty;
    private AlbumCollection albums = AlbumCollection.Empty;
    private PlaylistCollection playlists = PlaylistCollection.Empty;
    private GenreCollection genres = GenreCollection.Empty;
    private PictureCollection pictures = PictureCollection.Empty;
    private PictureCollection savedPictures = PictureCollection.Empty;
    private PictureAlbum rootPictureAlbum = PictureAlbum.Empty;
    private MediaSource mediaSource;
    private bool isDisposed;
    private static bool foo;
    private static object savePictureLock = new object();

    public MediaSource MediaSource
    {
      get
      {
        if (this.isDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        return this.mediaSource;
      }
    }

    static MediaLibrary() => MediaLibrary.mediaHelper = new MediaFinalizerHelper();

    public MediaLibrary()
      : this(MediaLibrary.PickBestMediaSource())
    {
    }

    private static MediaSource PickBestMediaSource()
    {
      IList<MediaSource> availableMediaSources = MediaSource.GetAvailableMediaSources();
      MediaSource mediaSource1 = (MediaSource) null;
      MediaSource mediaSource2 = (MediaSource) null;
      int num = 0;
      foreach (MediaSource mediaSource3 in (IEnumerable<MediaSource>) availableMediaSources)
      {
        switch (mediaSource3.MediaSourceType)
        {
          case MediaSourceType.LocalDevice:
            mediaSource2 = mediaSource3;
            continue;
          case MediaSourceType.WindowsMediaConnect:
            mediaSource1 = mediaSource3;
            ++num;
            continue;
          default:
            throw new InvalidOperationException(FrameworkResources.UnexpectedError);
        }
      }
      if (num == 1)
        return mediaSource1 != null ? mediaSource1 : throw new InvalidOperationException(FrameworkResources.UnexpectedError);
      return mediaSource2 != null ? mediaSource2 : throw new InvalidOperationException(FrameworkResources.UnexpectedError);
    }

    public void Dispose()
    {
      this.isDisposed = true;
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    public bool IsDisposed => this.isDisposed;

    ~MediaLibrary() => this.Dispose(false);

    public SongCollection Songs
    {
      [SecuritySafeCritical] get
      {
        if (this.isDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        if (this.songs == SongCollection.Empty)
        {
          uint maxValue = uint.MaxValue;
          if (Helpers.Succeeded(UnsafeNativeMethods.MediaLibrary_GetSongs(ref maxValue)))
            this.songs = new SongCollection(maxValue);
        }
        return this.songs;
      }
    }

    public ArtistCollection Artists
    {
      [SecuritySafeCritical] get
      {
        if (this.isDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        if (this.artists == ArtistCollection.Empty)
        {
          uint maxValue = uint.MaxValue;
          if (Helpers.Succeeded(UnsafeNativeMethods.MediaLibrary_GetArtists(ref maxValue)))
            this.artists = new ArtistCollection(maxValue);
        }
        return this.artists;
      }
    }

    public AlbumCollection Albums
    {
      [SecuritySafeCritical] get
      {
        if (this.isDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        if (this.albums == AlbumCollection.Empty)
        {
          uint maxValue = uint.MaxValue;
          if (Helpers.Succeeded(UnsafeNativeMethods.MediaLibrary_GetAlbums(ref maxValue)))
            this.albums = new AlbumCollection(maxValue);
        }
        return this.albums;
      }
    }

    public PlaylistCollection Playlists
    {
      [SecuritySafeCritical] get
      {
        if (this.isDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        if (this.playlists == PlaylistCollection.Empty)
        {
          uint maxValue = uint.MaxValue;
          if (Helpers.Succeeded(UnsafeNativeMethods.MediaLibrary_GetPlaylists(ref maxValue)))
            this.playlists = new PlaylistCollection(maxValue);
        }
        return this.playlists;
      }
    }

    public GenreCollection Genres
    {
      [SecuritySafeCritical] get
      {
        if (this.isDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        if (this.genres == GenreCollection.Empty)
        {
          uint maxValue = uint.MaxValue;
          if (Helpers.Succeeded(UnsafeNativeMethods.MediaLibrary_GetGenres(ref maxValue)))
            this.genres = new GenreCollection(maxValue);
        }
        return this.genres;
      }
    }

    public MediaLibrary(MediaSource mediaSource)
    {
      this.mediaSource = mediaSource;
      MediaLibrary.foo = true;
    }

    private void Dispose(bool disposing)
    {
      if (this.IsDisposed)
        return;
      this.isDisposed = true;
    }

    public PictureCollection Pictures
    {
      [SecuritySafeCritical] get
      {
        if (this.isDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        if (this.pictures == PictureCollection.Empty)
        {
          uint maxValue = uint.MaxValue;
          if (Helpers.Succeeded(UnsafeNativeMethods.MediaLibrary_GetPictures(ref maxValue)))
            this.pictures = new PictureCollection(maxValue);
        }
        return this.pictures;
      }
    }

    public PictureAlbum RootPictureAlbum
    {
      [SecuritySafeCritical] get
      {
        if (this.isDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        if (this.rootPictureAlbum == PictureAlbum.Empty)
        {
          uint maxValue = uint.MaxValue;
          if (Helpers.Succeeded(UnsafeNativeMethods.MediaLibrary_GetRootPictureAlbum(ref maxValue)))
            this.rootPictureAlbum = new PictureAlbum(maxValue);
        }
        return this.rootPictureAlbum;
      }
    }

    public Picture SavePictureToCameraRoll(string name, byte[] imageBuffer)
    {
      if (this.isDisposed)
        throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
      if (string.IsNullOrEmpty(name))
        throw new ArgumentOutOfRangeException(nameof (name));
      if (imageBuffer == null || imageBuffer.Length == 0)
        throw new ArgumentNullException(nameof (imageBuffer));
      using (MemoryStream memoryStream = new MemoryStream(imageBuffer))
        return this.SavePictureToCameraRoll(name, (Stream) memoryStream);
    }

    public Picture SavePictureToCameraRoll(string name, Stream source)
    {
      if (this.isDisposed)
        throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
      if (string.IsNullOrEmpty(name))
        throw new ArgumentOutOfRangeException(nameof (name));
      if (source == null)
        throw new ArgumentException("stream");
      lock (MediaLibrary.savePictureLock)
      {
        uint maxValue = uint.MaxValue;
        using (ImageStream streamFromSource = this.GetImageStreamFromSource(source))
        {
          string name1 = name;
          Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaLibrary_SavePictureToCameraRoll(name1, name1.Length, streamFromSource.Handle, ref maxValue));
        }
        return new Picture(maxValue);
      }
    }

    public Picture SavePicture(string name, byte[] imageBuffer)
    {
      if (this.isDisposed)
        throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
      if (string.IsNullOrEmpty(name))
        throw new ArgumentOutOfRangeException(nameof (name));
      if (imageBuffer == null || imageBuffer.Length == 0)
        throw new ArgumentNullException(nameof (imageBuffer));
      using (MemoryStream memoryStream = new MemoryStream(imageBuffer))
        return this.SavePicture(name, (Stream) memoryStream);
    }

    private ImageStream GetImageStreamFromSource(Stream source)
    {
      if (!(source is ImageStream imageStream))
        imageStream = ImageStream.FromStream(source);
      return imageStream;
    }

    [SecuritySafeCritical]
    public Picture SavePicture(string name, Stream source)
    {
      if (this.isDisposed)
        throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
      if (string.IsNullOrEmpty(name))
        throw new ArgumentOutOfRangeException(nameof (name));
      if (source == null)
        throw new ArgumentException("stream");
      lock (MediaLibrary.savePictureLock)
      {
        uint maxValue = uint.MaxValue;
        using (ImageStream streamFromSource = this.GetImageStreamFromSource(source))
        {
          string name1 = name;
          Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaLibrary_SavePicture(name1, name1.Length, streamFromSource.Handle, ref maxValue));
        }
        return new Picture(maxValue);
      }
    }

    public PictureCollection SavedPictures
    {
      [SecuritySafeCritical] get
      {
        if (this.isDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        if (this.pictures == PictureCollection.Empty)
        {
          uint maxValue = uint.MaxValue;
          if (Helpers.Succeeded(UnsafeNativeMethods.MediaLibrary_GetSavedPictures(ref maxValue)))
            this.pictures = new PictureCollection(maxValue);
        }
        return this.pictures;
      }
    }

    [SecuritySafeCritical]
    public Picture GetPictureFromToken(string token)
    {
      if (this.isDisposed)
        throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
      Guid guid;
      try
      {
        guid = new Guid(token);
      }
      catch (FormatException ex)
      {
        throw new ArgumentException();
      }
      uint maxValue = uint.MaxValue;
      Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaPicture_GetByGuid(ref guid, ref maxValue));
      return new Picture(maxValue);
    }
  }
}
