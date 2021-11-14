// Decompiled with JetBrains decompiler
// Type: Windows.Storage.KnownFolderId
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum KnownFolderId
  {
    AppCaptures,
    CameraRoll,
    DocumentsLibrary,
    HomeGroup,
    MediaServerDevices,
    MusicLibrary,
    Objects3D,
    PicturesLibrary,
    Playlists,
    RecordedCalls,
    RemovableDevices,
    SavedPictures,
    Screenshots,
    VideosLibrary,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] AllAppMods,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] CurrentAppMods,
  }
}
