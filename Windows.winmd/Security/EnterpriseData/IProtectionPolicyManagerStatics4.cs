// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.IProtectionPolicyManagerStatics4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Security.EnterpriseData
{
  [ContractVersion(typeof (EnterpriseDataContract), 262144)]
  [Guid(548902107, 52413, 18703, 140, 131, 73, 204, 183, 122, 234, 108)]
  [ExclusiveTo(typeof (ProtectionPolicyManager))]
  internal interface IProtectionPolicyManagerStatics4
  {
    bool IsRoamableProtectionEnabled(string identity);

    [Overload("RequestAccessWithBehaviorAsync")]
    [RemoteAsync]
    IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessAsync(
      string sourceIdentity,
      string targetIdentity,
      ProtectionPolicyAuditInfo auditInfo,
      string messageFromApp,
      ProtectionPolicyRequestAccessBehavior behavior);

    [Overload("RequestAccessForAppWithBehaviorAsync")]
    [RemoteAsync]
    IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessForAppAsync(
      string sourceIdentity,
      string appPackageFamilyName,
      ProtectionPolicyAuditInfo auditInfo,
      string messageFromApp,
      ProtectionPolicyRequestAccessBehavior behavior);

    [Overload("RequestAccessToFilesForAppAsync")]
    [RemoteAsync]
    IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessToFilesForAppAsync(
      IIterable<IStorageItem> sourceItemList,
      string appPackageFamilyName,
      ProtectionPolicyAuditInfo auditInfo);

    [Overload("RequestAccessToFilesForAppWithMessageAndBehaviorAsync")]
    [RemoteAsync]
    IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessToFilesForAppAsync(
      IIterable<IStorageItem> sourceItemList,
      string appPackageFamilyName,
      ProtectionPolicyAuditInfo auditInfo,
      string messageFromApp,
      ProtectionPolicyRequestAccessBehavior behavior);

    [RemoteAsync]
    [Overload("RequestAccessToFilesForProcessAsync")]
    IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessToFilesForProcessAsync(
      IIterable<IStorageItem> sourceItemList,
      uint processId,
      ProtectionPolicyAuditInfo auditInfo);

    [Overload("RequestAccessToFilesForProcessWithMessageAndBehaviorAsync")]
    [RemoteAsync]
    IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessToFilesForProcessAsync(
      IIterable<IStorageItem> sourceItemList,
      uint processId,
      ProtectionPolicyAuditInfo auditInfo,
      string messageFromApp,
      ProtectionPolicyRequestAccessBehavior behavior);

    [RemoteAsync]
    IAsyncOperation<bool> IsFileProtectionRequiredAsync(
      IStorageItem target,
      string identity);

    [RemoteAsync]
    IAsyncOperation<bool> IsFileProtectionRequiredForNewFileAsync(
      IStorageFolder parentFolder,
      string identity,
      string desiredName);

    string PrimaryManagedIdentity { get; }

    string GetPrimaryManagedIdentityForIdentity(string identity);
  }
}
