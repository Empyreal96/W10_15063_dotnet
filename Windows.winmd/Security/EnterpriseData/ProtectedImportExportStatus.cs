﻿// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.ProtectedImportExportStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Security.EnterpriseData
{
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  public enum ProtectedImportExportStatus
  {
    Ok,
    Undetermined,
    Unprotected,
    Revoked,
    NotRoamable,
    ProtectedToOtherIdentity,
    [ContractVersion("Windows.Security.EnterpriseData.EnterpriseDataContract", 131072)] LicenseExpired,
    [ContractVersion("Windows.Security.EnterpriseData.EnterpriseDataContract", 131072)] AccessSuspended,
  }
}
