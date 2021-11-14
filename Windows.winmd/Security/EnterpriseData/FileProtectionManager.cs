// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.FileProtectionManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Security.EnterpriseData
{
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IFileProtectionManagerStatics2), 131072, "Windows.Security.EnterpriseData.EnterpriseDataContract")]
  [Static(typeof (IFileProtectionManagerStatics), 65536, "Windows.Security.EnterpriseData.EnterpriseDataContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IFileProtectionManagerStatics3), 262144, "Windows.Security.EnterpriseData.EnterpriseDataContract")]
  public static class FileProtectionManager
  {
    [RemoteAsync]
    [Overload("UnprotectAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<FileProtectionInfo> UnprotectAsync(
      IStorageItem target);

    [Overload("UnprotectWithOptionsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<FileProtectionInfo> UnprotectAsync(
      IStorageItem target,
      FileUnprotectOptions options);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> IsContainerAsync(IStorageFile file);

    [Overload("LoadFileFromContainerWithTargetAndNameCollisionOptionAsync")]
    [RemoteAsync]
    [DefaultOverload]
    [MethodImpl]
    public static extern IAsyncOperation<ProtectedContainerImportResult> LoadFileFromContainerAsync(
      IStorageFile containerFile,
      IStorageItem target,
      NameCollisionOption collisionOption);

    [DefaultOverload]
    [RemoteAsync]
    [Overload("SaveFileAsContainerWithSharingAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<ProtectedContainerExportResult> SaveFileAsContainerAsync(
      IStorageFile protectedFile,
      IIterable<string> sharedWithIdentities);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<FileProtectionInfo> ProtectAsync(
      IStorageItem target,
      string identity);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> CopyProtectionAsync(
      IStorageItem source,
      IStorageItem target);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<FileProtectionInfo> GetProtectionInfoAsync(
      IStorageItem source);

    [RemoteAsync]
    [Overload("SaveFileAsContainerAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<ProtectedContainerExportResult> SaveFileAsContainerAsync(
      IStorageFile protectedFile);

    [RemoteAsync]
    [Overload("LoadFileFromContainerAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<ProtectedContainerImportResult> LoadFileFromContainerAsync(
      IStorageFile containerFile);

    [RemoteAsync]
    [Overload("LoadFileFromContainerWithTargetAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<ProtectedContainerImportResult> LoadFileFromContainerAsync(
      IStorageFile containerFile,
      IStorageItem target);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ProtectedFileCreateResult> CreateProtectedAndOpenAsync(
      IStorageFolder parentFolder,
      string desiredName,
      string identity,
      CreationCollisionOption collisionOption);
  }
}
