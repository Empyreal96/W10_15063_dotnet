// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.ProtectionPolicyManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;
using Windows.Storage;

namespace Windows.Security.EnterpriseData
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  [Static(typeof (IProtectionPolicyManagerStatics2), 131072, "Windows.Security.EnterpriseData.EnterpriseDataContract")]
  [Static(typeof (IProtectionPolicyManagerStatics), 65536, "Windows.Security.EnterpriseData.EnterpriseDataContract")]
  [Static(typeof (IProtectionPolicyManagerStatics3), 196608, "Windows.Security.EnterpriseData.EnterpriseDataContract")]
  [Static(typeof (IProtectionPolicyManagerStatics4), 262144, "Windows.Security.EnterpriseData.EnterpriseDataContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ProtectionPolicyManager : IProtectionPolicyManager, IProtectionPolicyManager2
  {
    public extern string Identity { [MethodImpl] set; [MethodImpl] get; }

    public extern bool ShowEnterpriseIndicator { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public static extern bool IsRoamableProtectionEnabled(string identity);

    [Overload("RequestAccessWithBehaviorAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessAsync(
      string sourceIdentity,
      string targetIdentity,
      ProtectionPolicyAuditInfo auditInfo,
      string messageFromApp,
      ProtectionPolicyRequestAccessBehavior behavior);

    [Overload("RequestAccessForAppWithBehaviorAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessForAppAsync(
      string sourceIdentity,
      string appPackageFamilyName,
      ProtectionPolicyAuditInfo auditInfo,
      string messageFromApp,
      ProtectionPolicyRequestAccessBehavior behavior);

    [Overload("RequestAccessToFilesForAppAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessToFilesForAppAsync(
      IIterable<IStorageItem> sourceItemList,
      string appPackageFamilyName,
      ProtectionPolicyAuditInfo auditInfo);

    [RemoteAsync]
    [Overload("RequestAccessToFilesForAppWithMessageAndBehaviorAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessToFilesForAppAsync(
      IIterable<IStorageItem> sourceItemList,
      string appPackageFamilyName,
      ProtectionPolicyAuditInfo auditInfo,
      string messageFromApp,
      ProtectionPolicyRequestAccessBehavior behavior);

    [RemoteAsync]
    [Overload("RequestAccessToFilesForProcessAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessToFilesForProcessAsync(
      IIterable<IStorageItem> sourceItemList,
      uint processId,
      ProtectionPolicyAuditInfo auditInfo);

    [Overload("RequestAccessToFilesForProcessWithMessageAndBehaviorAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessToFilesForProcessAsync(
      IIterable<IStorageItem> sourceItemList,
      uint processId,
      ProtectionPolicyAuditInfo auditInfo,
      string messageFromApp,
      ProtectionPolicyRequestAccessBehavior behavior);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> IsFileProtectionRequiredAsync(
      IStorageItem target,
      string identity);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> IsFileProtectionRequiredForNewFileAsync(
      IStorageFolder parentFolder,
      string identity,
      string desiredName);

    public static extern string PrimaryManagedIdentity { [MethodImpl] get; }

    [MethodImpl]
    public static extern string GetPrimaryManagedIdentityForIdentity(string identity);

    [Overload("RequestAccessWithAuditingInfoAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessAsync(
      string sourceIdentity,
      string targetIdentity,
      ProtectionPolicyAuditInfo auditInfo);

    [Overload("RequestAccessWithMessageAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessAsync(
      string sourceIdentity,
      string targetIdentity,
      ProtectionPolicyAuditInfo auditInfo,
      string messageFromApp);

    [Overload("RequestAccessForAppWithAuditingInfoAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessForAppAsync(
      string sourceIdentity,
      string appPackageFamilyName,
      ProtectionPolicyAuditInfo auditInfo);

    [Overload("RequestAccessForAppWithMessageAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessForAppAsync(
      string sourceIdentity,
      string appPackageFamilyName,
      ProtectionPolicyAuditInfo auditInfo,
      string messageFromApp);

    [MethodImpl]
    public static extern void LogAuditEvent(
      string sourceIdentity,
      string targetIdentity,
      ProtectionPolicyAuditInfo auditInfo);

    [MethodImpl]
    public static extern bool HasContentBeenRevokedSince(string identity, DateTime since);

    [MethodImpl]
    public static extern ProtectionPolicyEvaluationResult CheckAccessForApp(
      string sourceIdentity,
      string appPackageFamilyName);

    [Overload("RequestAccessForAppAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessForAppAsync(
      string sourceIdentity,
      string appPackageFamilyName);

    [MethodImpl]
    public static extern EnforcementLevel GetEnforcementLevel(string identity);

    [MethodImpl]
    public static extern bool IsUserDecryptionAllowed(string identity);

    [MethodImpl]
    public static extern bool IsProtectionUnderLockRequired(string identity);

    public static extern event EventHandler<object> PolicyChanged;

    public static extern bool IsProtectionEnabled { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool IsIdentityManaged(string identity);

    [MethodImpl]
    public static extern bool TryApplyProcessUIPolicy(string identity);

    [MethodImpl]
    public static extern void ClearProcessUIPolicy();

    [MethodImpl]
    public static extern ThreadNetworkContext CreateCurrentThreadNetworkContext(
      string identity);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> GetPrimaryManagedIdentityForNetworkEndpointAsync(
      HostName endpointHost);

    [MethodImpl]
    public static extern void RevokeContent(string identity);

    [MethodImpl]
    public static extern ProtectionPolicyManager GetForCurrentView();

    public static extern event EventHandler<ProtectedAccessSuspendingEventArgs> ProtectedAccessSuspending;

    public static extern event EventHandler<ProtectedAccessResumedEventArgs> ProtectedAccessResumed;

    public static extern event EventHandler<ProtectedContentRevokedEventArgs> ProtectedContentRevoked;

    [MethodImpl]
    public static extern ProtectionPolicyEvaluationResult CheckAccess(
      string sourceIdentity,
      string targetIdentity);

    [RemoteAsync]
    [Overload("RequestAccessAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessAsync(
      string sourceIdentity,
      string targetIdentity);
  }
}
