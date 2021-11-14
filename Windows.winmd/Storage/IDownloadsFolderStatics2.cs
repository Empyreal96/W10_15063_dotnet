// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IDownloadsFolderStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (DownloadsFolder))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(3912254909, 36600, 20366, 141, 21, 172, 14, 38, 95, 57, 13)]
  internal interface IDownloadsFolderStatics2
  {
    [Overload("CreateFileForUserAsync")]
    [RemoteAsync]
    IAsyncOperation<StorageFile> CreateFileForUserAsync(
      User user,
      string desiredName);

    [Overload("CreateFolderForUserAsync")]
    [RemoteAsync]
    IAsyncOperation<StorageFolder> CreateFolderForUserAsync(
      User user,
      string desiredName);

    [Overload("CreateFileForUserWithCollisionOptionAsync")]
    [RemoteAsync]
    IAsyncOperation<StorageFile> CreateFileForUserAsync(
      User user,
      string desiredName,
      CreationCollisionOption option);

    [RemoteAsync]
    [Overload("CreateFolderForUserWithCollisionOptionAsync")]
    IAsyncOperation<StorageFolder> CreateFolderForUserAsync(
      User user,
      string desiredName,
      CreationCollisionOption option);
  }
}
