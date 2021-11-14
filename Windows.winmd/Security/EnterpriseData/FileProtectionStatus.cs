// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.FileProtectionStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Security.EnterpriseData
{
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  public enum FileProtectionStatus
  {
    [ContractVersion("Windows.Security.EnterpriseData.EnterpriseDataContract", 65536), Deprecated("Undetermined might be unavailable after Windows 10. Instead, use Unknown.", DeprecationType.Deprecate, 65536, "Windows.Security.EnterpriseData.EnterpriseDataContract")] Undetermined = 0,
    [ContractVersion("Windows.Security.EnterpriseData.EnterpriseDataContract", 65536)] Unknown = 0,
    Unprotected = 1,
    Revoked = 2,
    Protected = 3,
    [Deprecated("ProtectedByOtherUser might be unavailable after Windows 10. Instead, use ProtectedToOtherIdentity.", DeprecationType.Deprecate, 65536, "Windows.Security.EnterpriseData.EnterpriseDataContract"), ContractVersion("Windows.Security.EnterpriseData.EnterpriseDataContract", 65536)] ProtectedByOtherUser = 4,
    [Deprecated("ProtectedToOtherEnterprise might be unavailable after Windows 10. Instead, use ProtectedToOtherIdentity.", DeprecationType.Deprecate, 65536, "Windows.Security.EnterpriseData.EnterpriseDataContract"), ContractVersion("Windows.Security.EnterpriseData.EnterpriseDataContract", 65536)] ProtectedToOtherEnterprise = 5,
    NotProtectable = 6,
    [ContractVersion("Windows.Security.EnterpriseData.EnterpriseDataContract", 65536)] ProtectedToOtherIdentity = 7,
    [ContractVersion("Windows.Security.EnterpriseData.EnterpriseDataContract", 131072)] LicenseExpired = 8,
    [ContractVersion("Windows.Security.EnterpriseData.EnterpriseDataContract", 131072)] AccessSuspended = 9,
    [ContractVersion("Windows.Security.EnterpriseData.EnterpriseDataContract", 196608)] FileInUse = 10, // 0x0000000A
  }
}
