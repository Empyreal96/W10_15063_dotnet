// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.IProtectionPolicyAuditInfoFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Security.EnterpriseData
{
  [Guid(2127829003, 37608, 17109, 131, 212, 37, 68, 11, 66, 53, 73)]
  [ContractVersion(typeof (EnterpriseDataContract), 196608)]
  [ExclusiveTo(typeof (ProtectionPolicyAuditInfo))]
  internal interface IProtectionPolicyAuditInfoFactory
  {
    ProtectionPolicyAuditInfo Create(
      ProtectionPolicyAuditAction action,
      string dataDescription,
      string sourceDescription,
      string targetDescription);

    ProtectionPolicyAuditInfo CreateWithActionAndDataDescription(
      ProtectionPolicyAuditAction action,
      string dataDescription);
  }
}
