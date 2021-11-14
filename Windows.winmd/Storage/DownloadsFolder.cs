// Decompiled with JetBrains decompiler
// Type: Windows.Storage.DownloadsFolder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage
{
  [Static(typeof (IDownloadsFolderStatics2), 131072, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IDownloadsFolderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class DownloadsFolder
  {
    [RemoteAsync]
    [Overload("CreateFileForUserAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFile> CreateFileForUserAsync(
      User user,
      string desiredName);

    [RemoteAsync]
    [Overload("CreateFolderForUserAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFolder> CreateFolderForUserAsync(
      User user,
      string desiredName);

    [RemoteAsync]
    [Overload("CreateFileForUserWithCollisionOptionAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFile> CreateFileForUserAsync(
      User user,
      string desiredName,
      CreationCollisionOption option);

    [RemoteAsync]
    [Overload("CreateFolderForUserWithCollisionOptionAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFolder> CreateFolderForUserAsync(
      User user,
      string desiredName,
      CreationCollisionOption option);

    [RemoteAsync]
    [Overload("CreateFileAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFile> CreateFileAsync(
      string desiredName);

    [Overload("CreateFolderAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFolder> CreateFolderAsync(
      string desiredName);

    [RemoteAsync]
    [Overload("CreateFileWithCollisionOptionAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFile> CreateFileAsync(
      string desiredName,
      CreationCollisionOption option);

    [RemoteAsync]
    [Overload("CreateFolderWithCollisionOptionAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFolder> CreateFolderAsync(
      string desiredName,
      CreationCollisionOption option);
  }
}
