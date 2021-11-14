// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.IProtectionPolicyManagerStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.EnterpriseData
{
  [ContractVersion(typeof (EnterpriseDataContract), 196608)]
  [Guid(1224711820, 27247, 19871, 188, 237, 24, 171, 83, 122, 160, 21)]
  [ExclusiveTo(typeof (ProtectionPolicyManager))]
  internal interface IProtectionPolicyManagerStatics3
  {
    [Overload("RequestAccessWithAuditingInfoAsync")]
    [RemoteAsync]
    IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessAsync(
      string sourceIdentity,
      string targetIdentity,
      ProtectionPolicyAuditInfo auditInfo);

    [RemoteAsync]
    [Overload("RequestAccessWithMessageAsync")]
    IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessAsync(
      string sourceIdentity,
      string targetIdentity,
      ProtectionPolicyAuditInfo auditInfo,
      string messageFromApp);

    [Overload("RequestAccessForAppWithAuditingInfoAsync")]
    [RemoteAsync]
    IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessForAppAsync(
      string sourceIdentity,
      string appPackageFamilyName,
      ProtectionPolicyAuditInfo auditInfo);

    [Overload("RequestAccessForAppWithMessageAsync")]
    [RemoteAsync]
    IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessForAppAsync(
      string sourceIdentity,
      string appPackageFamilyName,
      ProtectionPolicyAuditInfo auditInfo,
      string messageFromApp);

    void LogAuditEvent(
      string sourceIdentity,
      string targetIdentity,
      ProtectionPolicyAuditInfo auditInfo);
  }
}
