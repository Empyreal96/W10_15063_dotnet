// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Media.UnsafeNativeMethods
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Microsoft.Xna.Framework.Media
{
  [SecurityCritical]
  internal static class UnsafeNativeMethods
  {
    internal const uint visualizationBufferSize = 256;
    private const string XnaFrameworkCoreDll = "XnaFrameworkCore";

    [DllImport("XnaFrameworkCore")]
    internal static extern ErrorCodes Media_Initialize();

    [DllImport("XnaFrameworkCore")]
    internal static extern ErrorCodes Media_Shutdown();

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Library_GetSongs")]
    internal static extern ErrorCodes MediaLibrary_GetSongs(ref uint handle);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Library_GetArtists")]
    internal static extern ErrorCodes MediaLibrary_GetArtists(ref uint handle);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Library_GetAlbums")]
    internal static extern ErrorCodes MediaLibrary_GetAlbums(ref uint handle);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Library_GetPlaylists")]
    internal static extern ErrorCodes MediaLibrary_GetPlaylists(ref uint handle);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Library_GetGenres")]
    internal static extern ErrorCodes MediaLibrary_GetGenres(ref uint handle);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Library_GetPictures")]
    internal static extern ErrorCodes MediaLibrary_GetPictures(ref uint handle);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Library_GetRootPictureAlbum")]
    internal static extern ErrorCodes MediaLibrary_GetRootPictureAlbum(ref uint handle);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Library_SavePicture")]
    internal static extern ErrorCodes MediaLibrary_SavePicture(
      [MarshalAs(UnmanagedType.LPWStr)] string name,
      int nameLength,
      uint stream,
      ref uint picture);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Library_SavePictureToCameraRoll")]
    internal static extern ErrorCodes MediaLibrary_SavePictureToCameraRoll(
      [MarshalAs(UnmanagedType.LPWStr)] string name,
      int nameLength,
      uint stream,
      ref uint picture);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Library_GetSavedPictures")]
    internal static extern ErrorCodes MediaLibrary_GetSavedPictures(ref uint handle);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_List_GetCount")]
    internal static extern ErrorCodes MediaList_GetCount(
      uint handleSongList,
      ref int count);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_List_GetItemAtIndex")]
    internal static extern ErrorCodes MediaList_GetItemAtIndex(
      uint handleSongList,
      int index,
      ref uint itemId);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_List_Release")]
    internal static extern ErrorCodes MediaList_Release(uint handleSongList);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Item_Release")]
    internal static extern ErrorCodes MediaItem_Release(uint handleItem);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Item_GetName")]
    internal static extern ErrorCodes MediaItem_GetName(
      uint itemId,
      [MarshalAs(UnmanagedType.LPWStr)] StringBuilder sbName,
      uint charCount);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Item_IsEqual")]
    internal static extern ErrorCodes MediaItem_IsEqual(
      uint first,
      uint second,
      ref bool equal);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Song_IsEqualTitleSong")]
    internal static extern ErrorCodes MediaSong_IsEqualTitleSong(
      [MarshalAs(UnmanagedType.LPWStr)] string filename,
      int filenameLength,
      uint handle,
      ref bool equal);

    internal static ErrorCodes MediaSong_FromUri(string name, Uri uri, ref uint song)
    {
      string str = uri.ToString();
      string name1 = name;
      int length1 = name1.Length;
      string uri1 = str;
      int length2 = uri1.Length;
      int num = !uri.IsAbsoluteUri ? 1 : 0;
      ref uint local = ref song;
      return UnsafeNativeMethods.MediaSong_FromUriInternal(name1, length1, uri1, length2, num != 0, ref local);
    }

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Song_FromUri")]
    internal static extern ErrorCodes MediaSong_FromUriInternal(
      [MarshalAs(UnmanagedType.LPWStr)] string name,
      int nameLength,
      [MarshalAs(UnmanagedType.LPWStr)] string uri,
      int uriLength,
      bool relative,
      ref uint song);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Song_GetArtist")]
    internal static extern ErrorCodes MediaSong_GetArtist(uint song, ref uint artist);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Song_GetAlbum")]
    internal static extern ErrorCodes MediaSong_GetAlbum(uint song, ref uint album);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Song_GetGenre")]
    internal static extern ErrorCodes MediaSong_GetGenre(uint song, ref uint genre);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Song_GetDuration")]
    internal static extern ErrorCodes MediaSong_GetDuration(uint song, ref int duration);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Song_GetTrackNumber")]
    internal static extern ErrorCodes MediaSong_GetTrackNumber(
      uint song,
      ref int trackNumber);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Song_GetRating")]
    internal static extern ErrorCodes MediaSong_GetRating(uint song, ref int rating);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Song_GetPlayCount")]
    internal static extern ErrorCodes MediaSong_GetPlayCount(uint song, ref int playCount);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Song_IsRestricted")]
    internal static extern ErrorCodes MediaSong_IsRestricted(
      uint song,
      ref bool restricted);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Album_GetArtist")]
    internal static extern ErrorCodes MediaAlbum_GetArtist(uint album, ref uint artist);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Album_GetSongs")]
    internal static extern ErrorCodes MediaAlbum_GetSongs(uint album, ref uint songs);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Album_GetGenre")]
    internal static extern ErrorCodes MediaAlbum_GetGenre(uint album, ref uint genre);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Album_GetDuration")]
    internal static extern ErrorCodes MediaAlbum_GetDuration(uint album, ref int duration);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Album_HasArt")]
    internal static extern ErrorCodes MediaAlbum_HasArt(uint album, ref bool hasArt);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Album_GetArtStream")]
    internal static extern ErrorCodes MediaAlbum_GetArtStream(
      uint album,
      bool thumbnail,
      ref uint stream);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Artist_GetSongs")]
    internal static extern ErrorCodes MediaArtist_GetSongs(uint artist, ref uint songs);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Artist_GetAlbums")]
    internal static extern ErrorCodes MediaArtist_GetAlbums(uint artist, ref uint albums);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Genre_GetSongs")]
    internal static extern ErrorCodes MediaGenre_GetSongs(uint genre, ref uint songs);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Genre_GetAlbums")]
    internal static extern ErrorCodes MediaGenre_GetAlbums(uint genre, ref uint albums);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Playlist_GetSongs")]
    internal static extern ErrorCodes MediaPlaylist_GetSongs(
      uint playlist,
      ref uint songs);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Playlist_GetDuration")]
    internal static extern ErrorCodes MediaPlaylist_GetDuration(
      uint playlist,
      ref int duration);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_PlaySong")]
    internal static extern ErrorCodes MediaQueue_PlaySong(uint song);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_PlaySongFromFile")]
    internal static extern ErrorCodes MediaQueue_PlaySongFromFile(
      [MarshalAs(UnmanagedType.LPWStr)] string name,
      uint nameLength,
      [MarshalAs(UnmanagedType.LPWStr)] string path,
      uint pathLength,
      int duration);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_PlaySongList")]
    internal static extern ErrorCodes MediaQueue_PlaySongList(uint songList, int index);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_MoveTo")]
    internal static extern ErrorCodes MediaQueue_MoveTo(int songIndex);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_MoveNext")]
    internal static extern ErrorCodes MediaQueue_MoveNext();

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_MovePrev")]
    internal static extern ErrorCodes MediaQueue_MovePrev();

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_GetSongCount")]
    internal static extern ErrorCodes MediaQueue_GetSongCount(ref int songCount);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_GetSongAtIndex")]
    internal static extern ErrorCodes MediaQueue_GetSongAtIndex(int index, ref uint song);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_GetPlayPosition")]
    internal static extern ErrorCodes MediaQueue_GetPlayPosition(ref int position);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_GetShuffle")]
    internal static extern ErrorCodes MediaQueue_GetShuffle(ref bool shuffle);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_SetShuffle")]
    internal static extern ErrorCodes MediaQueue_SetShuffle(bool shuffle);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_GetRepeat")]
    internal static extern ErrorCodes MediaQueue_GetRepeat(ref bool repeat);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_SetRepeat")]
    internal static extern ErrorCodes MediaQueue_SetRepeat(bool repeat);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_Pause")]
    internal static extern ErrorCodes MediaQueue_Pause();

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_Resume")]
    internal static extern ErrorCodes MediaQueue_Resume();

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_Stop")]
    internal static extern ErrorCodes MediaQueue_Stop();

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_GameHasControl")]
    internal static extern ErrorCodes MediaPlayer_GameHasControl(ref bool gameHasControl);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_GetPlayState")]
    internal static extern ErrorCodes MediaQueue_GetPlayState(ref MediaState state);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_GetActiveSongIndex")]
    internal static extern ErrorCodes MediaQueue_GetActiveSongIndex(ref int songIndex);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_GetActiveSong")]
    internal static extern ErrorCodes MediaQueue_GetActiveSong(ref uint song);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_GetVolume")]
    internal static extern ErrorCodes MediaQueue_GetVolume(ref float volume);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_SetVolume")]
    internal static extern ErrorCodes MediaQueue_SetVolume(float volume);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_IsMuted")]
    internal static extern ErrorCodes MediaQueue_IsMuted(ref bool muted);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_SetMute")]
    internal static extern ErrorCodes MediaQueue_SetMute(bool mute);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_EnableVisualization")]
    internal static extern ErrorCodes MediaQueue_EnableVisualization(bool enable);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_IsVisualizationEnabled")]
    internal static extern ErrorCodes MediaQueue_IsVisualizationEnabled(ref bool enabled);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Queue_GetVisualizationData")]
    internal static extern ErrorCodes MediaQueue_GetVisualizationData(
      [MarshalAs(UnmanagedType.LPArray)] float[] frequencies,
      int freqLen,
      [MarshalAs(UnmanagedType.LPArray)] float[] samples,
      int sampleLen);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Picture_GetAlbum")]
    internal static extern ErrorCodes MediaPicture_GetAlbum(uint picture, ref uint album);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Picture_GetDimensions")]
    internal static extern ErrorCodes MediaPicture_GetDimensions(
      uint picture,
      ref int width,
      ref int height);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Picture_GetDate")]
    internal static extern ErrorCodes MediaPicture_GetDate(
      uint picture,
      ref long filetime);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Picture_GetByGuid")]
    internal static extern ErrorCodes MediaPicture_GetByGuid(
      ref Guid guid,
      ref uint picture);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_Picture_GetStream")]
    internal static extern ErrorCodes MediaPicture_GetStream(
      uint picture,
      PictureStreamType streamType,
      ref uint stream);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_PictureAlbum_GetChildAlbums")]
    internal static extern ErrorCodes MediaPictureAlbum_GetChildAlbums(
      uint album,
      ref uint childrenAlbums);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_PictureAlbum_GetPictures")]
    internal static extern ErrorCodes MediaPictureAlbum_GetPictures(
      uint album,
      ref uint pictures);

    [DllImport("XnaFrameworkCore", EntryPoint = "Media_PictureAlbum_GetParentAlbum")]
    internal static extern ErrorCodes MediaPictureAlbum_GetParentAlbum(
      uint album,
      ref uint parent);

    [DllImport("XnaFrameworkCore", EntryPoint = "Imaging_CreateKernelStreamForManagedStream")]
    internal static extern unsafe ErrorCodes CreateKernelStream(
      IntPtr read,
      IntPtr write,
      IntPtr seek,
      IntPtr length,
      uint* handle);

    [DllImport("XnaFrameworkCore", EntryPoint = "Imaging_CreateKernelMemoryStream")]
    internal static extern unsafe ErrorCodes CreateKernelStream(
      byte* buffer,
      int length,
      uint* handle);

    [DllImport("XnaFrameworkCore", EntryPoint = "Imaging_ReadFromStream")]
    internal static extern unsafe ErrorCodes ReadFromStream(
      uint handle,
      byte* buffer,
      int length,
      int* read);

    [DllImport("XnaFrameworkCore", EntryPoint = "Imaging_SeekInStream")]
    internal static extern unsafe ErrorCodes SeekInStream(
      uint handle,
      long offset,
      int origin,
      long* position);

    [DllImport("XnaFrameworkCore", EntryPoint = "Imaging_GetStreamLength")]
    internal static extern unsafe ErrorCodes GetStreamLength(uint handle, long* length);

    [DllImport("XnaFrameworkCore", EntryPoint = "Imaging_CloseKernelStream")]
    internal static extern ErrorCodes CloseKernelStream(uint handle);

    [DllImport("XnaFrameworkCore", EntryPoint = "Imaging_EncodeBufferToStream")]
    internal static extern unsafe ErrorCodes EncodeBufferToStream(
      XnaImageFormat format,
      byte* buffer,
      int length,
      int sourceWidth,
      int sourceHeight,
      int targetWidth,
      int targetHeight,
      uint* handle);
  }
}
