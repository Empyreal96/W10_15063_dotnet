// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Media.PhoneExtensions.MediaLibraryExtensions
// Assembly: Microsoft.Xna.Framework.MediaLibraryExtensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 04C233BD-5657-44BB-8EEE-63321B92241D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIE731~1.DLL

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Microsoft.Xna.Framework.Media.PhoneExtensions
{
  public static class MediaLibraryExtensions
  {
    private const uint ZERROR_E_ALREADYEXISTS = 2151284935;
    private const uint ZERROR_E_USER_DECLINED_DELETE = 2151284972;
    private const uint ZERROR_E_UNSUPPORTED_IMAGE_TYPE = 2151284973;
    private const uint FILE_NOT_FOUND = 2147942402;
    private const uint ZERROR_E_BAD_SONG_METADATA = 2151284976;
    private const uint ERROR_INSUFFICIENT_BUFFER = 2147942522;

    public static Song SaveSong(
      this MediaLibrary library,
      Uri filename,
      SongMetadata songMetadata,
      SaveSongOperation operation)
    {
      if ((Uri) null == filename)
        throw new ArgumentNullException(nameof (filename));
      if (songMetadata != null && (songMetadata.Duration.TotalMilliseconds < 0.0 || songMetadata.Duration.TotalMilliseconds >= (double) int.MaxValue))
        throw new InvalidOperationException("The song's Duration must be a positive integer, less than int.MaxValue");
      uint zmediaitem;
      if (songMetadata != null)
      {
        MyNativeMethods.MEDIAAPI_SONGMETADATA songMetadata1;
        songMetadata1.Name = songMetadata.Name;
        songMetadata1.DurationMSec = (uint) songMetadata.Duration.TotalMilliseconds;
        songMetadata1.ArtistName = songMetadata.ArtistName;
        songMetadata1.GenreName = songMetadata.GenreName;
        songMetadata1.AlbumName = songMetadata.AlbumName;
        songMetadata1.TrackNumber = (uint) songMetadata.TrackNumber;
        songMetadata1.AlbumArtistName = songMetadata.AlbumArtistName;
        ref MyNativeMethods.MEDIAAPI_SONGMETADATA local = ref songMetadata1;
        DateTime albumReleaseDate = songMetadata.AlbumReleaseDate;
        string str = songMetadata.AlbumReleaseDate.ToString("yyyy-MM-dd:HH:mm:ss");
        local.AlbumReleaseDate = str;
        songMetadata1.AlbumArtUri = songMetadata.AlbumArtUri.ToStringOrNull<Uri>();
        songMetadata1.ArtistBackgroundUri = songMetadata.ArtistBackgroundUri.ToStringOrNull<Uri>();
        songMetadata1.AlbumArtistBackgroundUri = songMetadata.AlbumArtistBackgroundUri.ToStringOrNull<Uri>();
        zmediaitem = MediaLibraryExtensions.SaveSongInternal(filename.ToString(), songMetadata1, operation);
      }
      else
        zmediaitem = MediaLibraryExtensions.SaveSongInternal(filename.ToString(), IntPtr.Zero, operation);
      return new Song(MediaLibraryExtensions.GetHandleForZMediaItem(zmediaitem));
    }

    public static void Delete(this MediaLibrary library, Song song) => MediaLibraryExtensions.DeleteSongInternal(MediaLibraryExtensions.GetZMediaItemForHandle(song.Handle));

    public static string GetPathFromToken(this MediaLibrary library, string token)
    {
      Guid empty1 = Guid.Empty;
      string empty2 = string.Empty;
      Guid token1;
      try
      {
        token1 = new Guid(token);
      }
      catch (FormatException ex)
      {
        throw new ArgumentException();
      }
      return MediaLibraryExtensions.GetPathFromTokenInternal(token1);
    }

    public static string GetPath(this Picture picture) => MediaLibraryExtensions.GetPathFromItemInternal(MediaLibraryExtensions.GetZMediaItemForHandle(picture.Handle));

    public static Stream GetPreviewImage(this Picture picture)
    {
      uint maxValue = uint.MaxValue;
      Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaPicture_GetStream(picture.Handle, PictureStreamType.Small, ref maxValue));
      return (Stream) new ImageStream(maxValue);
    }

    internal static string ToStringOrNull<T>(this T arg) where T : class => (object) arg == null ? (string) null : arg.ToString();

    [SecuritySafeCritical]
    private static void DeleteSongInternal(uint zmediaitem) => MediaLibraryExtensions.ThrowExceptionFromResult(MyNativeMethods.MediaApi_DeleteSong(zmediaitem));

    [SecuritySafeCritical]
    private static uint GetHandleForZMediaItem(uint zmediaitem)
    {
      uint handle = 0;
      MediaLibraryExtensions.ThrowExceptionFromResult(MyNativeMethods.Media_HandleFromMediaItem(zmediaitem, ref handle));
      return handle;
    }

    [SecuritySafeCritical]
    private static uint GetZMediaItemForHandle(uint handle)
    {
      uint zmediaitem = 0;
      MediaLibraryExtensions.ThrowExceptionFromResult(MyNativeMethods.Media_MediaItemFromHandle(handle, ref zmediaitem));
      return zmediaitem;
    }

    [SecuritySafeCritical]
    private static uint SaveSongInternal(
      string filename,
      MyNativeMethods.MEDIAAPI_SONGMETADATA songMetadata,
      SaveSongOperation operation)
    {
      IntPtr num = Marshal.AllocCoTaskMem(Marshal.SizeOf((object) songMetadata));
      try
      {
        Marshal.StructureToPtr((object) songMetadata, num, false);
        try
        {
          return MediaLibraryExtensions.SaveSongInternal(filename, num, operation);
        }
        finally
        {
          Marshal.StructureToPtr((object) new MyNativeMethods.MEDIAAPI_SONGMETADATA(), num, true);
        }
      }
      finally
      {
        Marshal.FreeCoTaskMem(num);
      }
    }

    [SecuritySafeCritical]
    private static uint SaveSongInternal(
      string filename,
      IntPtr pSongMetadata,
      SaveSongOperation operation)
    {
      uint zmediaitem = 0;
      MediaLibraryExtensions.ThrowExceptionFromResult(MyNativeMethods.MediaApi_SaveSong(filename, pSongMetadata, operation, ref zmediaitem));
      return zmediaitem;
    }

    [SecuritySafeCritical]
    private static string GetPathFromTokenInternal(Guid token)
    {
      StringBuilder stringBuilder = new StringBuilder(260);
      ref Guid local = ref token;
      StringBuilder sbFilePath = stringBuilder;
      int capacity = sbFilePath.Capacity;
      MediaLibraryExtensions.ThrowExceptionFromResult(MyNativeMethods.MediaApi_GetPathFromToken(ref local, sbFilePath, capacity));
      return stringBuilder.ToString();
    }

    [SecuritySafeCritical]
    private static string GetPathFromItemInternal(uint zmediaitem)
    {
      StringBuilder stringBuilder = new StringBuilder(260);
      int num = (int) zmediaitem;
      StringBuilder sbFilePath = stringBuilder;
      int capacity = sbFilePath.Capacity;
      MediaLibraryExtensions.ThrowExceptionFromResult(MyNativeMethods.MediaApi_GetPathFromItem((uint) num, sbFilePath, capacity));
      return stringBuilder.ToString();
    }

    private static void ThrowExceptionFromResult(ErrorCodes result)
    {
      if (result == ErrorCodes.Success)
        return;
      Exception exceptionFromResult = MediaLibraryExtensions.GetExceptionFromResult((uint) result);
      if (exceptionFromResult != null)
        throw exceptionFromResult;
    }

    private static Exception GetExceptionFromResult(uint result)
    {
      switch (result)
      {
        case 0:
          return (Exception) null;
        case 2147942402:
          return (Exception) new FileNotFoundException("The specified file (either the media or image) doesn't exist.");
        case 2147942522:
        case 2151284976:
          return (Exception) new InvalidOperationException("The provided metadata for the song isn't correct");
        case 2151284935:
          return (Exception) new InvalidOperationException("The song already exists in the library.");
        case 2151284972:
          return (Exception) new UnauthorizedAccessException("The user declined the delete request.");
        case 2151284973:
          return (Exception) new InvalidOperationException("The Image File(s) provided for artwork are not JPG files.");
        default:
          return Helpers.GetExceptionFromResult(result);
      }
    }
  }
}
