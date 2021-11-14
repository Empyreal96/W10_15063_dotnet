// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.IFileRevocationManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Security.EnterpriseData
{
  [ExclusiveTo(typeof (FileRevocationManager))]
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  [Guid(627817533, 7261, 16992, 140, 117, 145, 68, 207, 183, 139, 169)]
  [Deprecated("FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager.", DeprecationType.Deprecate, 65536, "Windows.Security.EnterpriseData.EnterpriseDataContract")]
  internal interface IFileRevocationManagerStatics
  {
    [RemoteAsync]
    [Deprecated("FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager.", DeprecationType.Deprecate, 65536, "Windows.Security.EnterpriseData.EnterpriseDataContract")]
    IAsyncOperation<FileProtectionStatus> ProtectAsync(
      IStorageItem storageItem,
      string enterpriseIdentity);

    [Deprecated("FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager.", DeprecationType.Deprecate, 65536, "Windows.Security.EnterpriseData.EnterpriseDataContract")]
    [RemoteAsync]
    IAsyncOperation<bool> CopyProtectionAsync(
      IStorageItem sourceStorageItem,
      IStorageItem targetStorageItem);

    [Deprecated("FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager.", DeprecationType.Deprecate, 65536, "Windows.Security.EnterpriseData.EnterpriseDataContract")]
    void Revoke(string enterpriseIdentity);

    [RemoteAsync]
    [Deprecated("FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager.", DeprecationType.Deprecate, 65536, "Windows.Security.EnterpriseData.EnterpriseDataContract")]
    IAsyncOperation<FileProtectionStatus> GetStatusAsync(
      IStorageItem storageItem);
  }
}
