// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Media.PhoneExtensions.MyNativeMethods
// Assembly: Microsoft.Xna.Framework.MediaLibraryExtensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 04C233BD-5657-44BB-8EEE-63321B92241D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIE731~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Microsoft.Xna.Framework.Media.PhoneExtensions
{
  [SecuritySafeCritical]
  internal static class MyNativeMethods
  {
    private const string XnaFrameworkCoreDll = "XnaFrameworkCore";
    private const string MediaApi = "MediaApi";
    private const string PhotosApi = "PhotosApi";

    [DllImport("XnaFrameworkCore")]
    internal static extern ErrorCodes Media_HandleFromMediaItem(
      uint zmediaitem,
      ref uint handle);

    [DllImport("XnaFrameworkCore")]
    internal static extern ErrorCodes Media_MediaItemFromHandle(
      uint handle,
      ref uint zmediaitem);

    [DllImport("MediaApi")]
    internal static extern ErrorCodes MediaApi_SaveSong(
      [MarshalAs(UnmanagedType.LPWStr)] string fileName,
      IntPtr songMetadata,
      SaveSongOperation operation,
      ref uint zmediaitem);

    [DllImport("MediaApi")]
    internal static extern ErrorCodes MediaApi_DeleteSong(uint zmediaitem);

    [DllImport("PhotosApi")]
    internal static extern ErrorCodes MediaApi_GetPathFromToken(
      ref Guid token,
      [MarshalAs(UnmanagedType.LPWStr)] StringBuilder sbFilePath,
      int cchFilePath);

    [DllImport("PhotosApi")]
    internal static extern ErrorCodes MediaApi_GetPathFromItem(
      uint zmediaitem,
      [MarshalAs(UnmanagedType.LPWStr)] StringBuilder sbFilePath,
      int cchFilePath);

    internal struct MEDIAAPI_SONGMETADATA
    {
      [MarshalAs(UnmanagedType.LPWStr)]
      internal string Name;
      [MarshalAs(UnmanagedType.U4)]
      internal uint DurationMSec;
      [MarshalAs(UnmanagedType.LPWStr)]
      internal string ArtistName;
      [MarshalAs(UnmanagedType.LPWStr)]
      internal string GenreName;
      [MarshalAs(UnmanagedType.LPWStr)]
      internal string AlbumName;
      [MarshalAs(UnmanagedType.U4)]
      internal uint TrackNumber;
      [MarshalAs(UnmanagedType.LPWStr)]
      internal string AlbumArtistName;
      [MarshalAs(UnmanagedType.LPWStr)]
      internal string AlbumReleaseDate;
      [MarshalAs(UnmanagedType.LPWStr)]
      internal string AlbumArtUri;
      [MarshalAs(UnmanagedType.LPWStr)]
      internal string ArtistBackgroundUri;
      [MarshalAs(UnmanagedType.LPWStr)]
      internal string AlbumArtistBackgroundUri;
    }
  }
}
