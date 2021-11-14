// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IKnownFoldersPlaylistsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [Guid(3671452886, 12399, 19818, 180, 150, 70, 186, 142, 177, 6, 206)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KnownFolders))]
  internal interface IKnownFoldersPlaylistsStatics
  {
    StorageFolder Playlists { get; }
  }
}
