// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.FileRevocationManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Security.EnterpriseData
{
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IFileRevocationManagerStatics), 65536, "Windows.Security.EnterpriseData.EnterpriseDataContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager.", DeprecationType.Deprecate, 65536, "Windows.Security.EnterpriseData.EnterpriseDataContract")]
  public static class FileRevocationManager
  {
    [Deprecated("FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager.", DeprecationType.Deprecate, 65536, "Windows.Security.EnterpriseData.EnterpriseDataContract")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<FileProtectionStatus> ProtectAsync(
      IStorageItem storageItem,
      string enterpriseIdentity);

    [Deprecated("FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager.", DeprecationType.Deprecate, 65536, "Windows.Security.EnterpriseData.EnterpriseDataContract")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> CopyProtectionAsync(
      IStorageItem sourceStorageItem,
      IStorageItem targetStorageItem);

    [Deprecated("FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager.", DeprecationType.Deprecate, 65536, "Windows.Security.EnterpriseData.EnterpriseDataContract")]
    [MethodImpl]
    public static extern void Revoke(string enterpriseIdentity);

    [Deprecated("FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager.", DeprecationType.Deprecate, 65536, "Windows.Security.EnterpriseData.EnterpriseDataContract")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<FileProtectionStatus> GetStatusAsync(
      IStorageItem storageItem);
  }
}
