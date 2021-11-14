// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IKnownFoldersStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1512731936, 18434, 17709, 154, 217, 67, 81, 173, 167, 236, 53)]
  [ExclusiveTo(typeof (KnownFolders))]
  internal interface IKnownFoldersStatics
  {
    StorageFolder MusicLibrary { get; }

    StorageFolder PicturesLibrary { get; }

    StorageFolder VideosLibrary { get; }

    StorageFolder DocumentsLibrary { get; }

    StorageFolder HomeGroup { get; }

    StorageFolder RemovableDevices { get; }

    StorageFolder MediaServerDevices { get; }
  }
}
