// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.IProtectionPolicyManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking;

namespace Windows.Security.EnterpriseData
{
  [Guid(3233807462, 35901, 19798, 136, 4, 198, 143, 10, 211, 46, 197)]
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  [ExclusiveTo(typeof (ProtectionPolicyManager))]
  internal interface IProtectionPolicyManagerStatics
  {
    bool IsIdentityManaged(string identity);

    bool TryApplyProcessUIPolicy(string identity);

    void ClearProcessUIPolicy();

    ThreadNetworkContext CreateCurrentThreadNetworkContext(string identity);

    [RemoteAsync]
    IAsyncOperation<string> GetPrimaryManagedIdentityForNetworkEndpointAsync(
      HostName endpointHost);

    void RevokeContent(string identity);

    ProtectionPolicyManager GetForCurrentView();

    event EventHandler<ProtectedAccessSuspendingEventArgs> ProtectedAccessSuspending;

    event EventHandler<ProtectedAccessResumedEventArgs> ProtectedAccessResumed;

    event EventHandler<ProtectedContentRevokedEventArgs> ProtectedContentRevoked;

    ProtectionPolicyEvaluationResult CheckAccess(
      string sourceIdentity,
      string targetIdentity);

    [Overload("RequestAccessAsync")]
    [RemoteAsync]
    IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessAsync(
      string sourceIdentity,
      string targetIdentity);
  }
}
