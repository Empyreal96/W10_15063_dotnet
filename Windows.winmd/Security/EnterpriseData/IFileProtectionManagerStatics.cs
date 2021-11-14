// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.IFileProtectionManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Security.EnterpriseData
{
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  [ExclusiveTo(typeof (FileProtectionManager))]
  [Guid(1481047195, 58899, 17003, 187, 56, 136, 203, 161, 220, 154, 219)]
  internal interface IFileProtectionManagerStatics
  {
    [RemoteAsync]
    IAsyncOperation<FileProtectionInfo> ProtectAsync(
      IStorageItem target,
      string identity);

    [RemoteAsync]
    IAsyncOperation<bool> CopyProtectionAsync(
      IStorageItem source,
      IStorageItem target);

    [RemoteAsync]
    IAsyncOperation<FileProtectionInfo> GetProtectionInfoAsync(
      IStorageItem source);

    [RemoteAsync]
    [Overload("SaveFileAsContainerAsync")]
    IAsyncOperation<ProtectedContainerExportResult> SaveFileAsContainerAsync(
      IStorageFile protectedFile);

    [Overload("LoadFileFromContainerAsync")]
    [RemoteAsync]
    IAsyncOperation<ProtectedContainerImportResult> LoadFileFromContainerAsync(
      IStorageFile containerFile);

    [RemoteAsync]
    [Overload("LoadFileFromContainerWithTargetAsync")]
    IAsyncOperation<ProtectedContainerImportResult> LoadFileFromContainerAsync(
      IStorageFile containerFile,
      IStorageItem target);

    [RemoteAsync]
    IAsyncOperation<ProtectedFileCreateResult> CreateProtectedAndOpenAsync(
      IStorageFolder parentFolder,
      string desiredName,
      string identity,
      CreationCollisionOption collisionOption);
  }
}
