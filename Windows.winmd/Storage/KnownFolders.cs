// Decompiled with JetBrains decompiler
// Type: Windows.Storage.KnownFolders
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage
{
  [Static(typeof (IKnownFoldersSavedPicturesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IKnownFoldersStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IKnownFoldersCameraRollStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IKnownFoldersPlaylistsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IKnownFoldersStatics3), 131072, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IKnownFoldersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class KnownFolders
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFolder> GetFolderForUserAsync(
      User user,
      KnownFolderId folderId);

    public static extern StorageFolder Objects3D { [MethodImpl] get; }

    public static extern StorageFolder AppCaptures { [MethodImpl] get; }

    public static extern StorageFolder RecordedCalls { [MethodImpl] get; }

    public static extern StorageFolder SavedPictures { [MethodImpl] get; }

    public static extern StorageFolder CameraRoll { [MethodImpl] get; }

    public static extern StorageFolder Playlists { [MethodImpl] get; }

    public static extern StorageFolder MusicLibrary { [MethodImpl] get; }

    public static extern StorageFolder PicturesLibrary { [MethodImpl] get; }

    public static extern StorageFolder VideosLibrary { [MethodImpl] get; }

    public static extern StorageFolder DocumentsLibrary { [MethodImpl] get; }

    public static extern StorageFolder HomeGroup { [MethodImpl] get; }

    public static extern StorageFolder RemovableDevices { [MethodImpl] get; }

    public static extern StorageFolder MediaServerDevices { [MethodImpl] get; }
  }
}
