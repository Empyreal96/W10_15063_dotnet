// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.IProtectionPolicyManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.EnterpriseData
{
  [ExclusiveTo(typeof (ProtectionPolicyManager))]
  [ContractVersion(typeof (EnterpriseDataContract), 131072)]
  [Guid(3062864524, 14816, 17993, 178, 228, 7, 10, 184, 165, 121, 179)]
  internal interface IProtectionPolicyManagerStatics2
  {
    bool HasContentBeenRevokedSince(string identity, DateTime since);

    ProtectionPolicyEvaluationResult CheckAccessForApp(
      string sourceIdentity,
      string appPackageFamilyName);

    [Overload("RequestAccessForAppAsync")]
    [RemoteAsync]
    IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessForAppAsync(
      string sourceIdentity,
      string appPackageFamilyName);

    EnforcementLevel GetEnforcementLevel(string identity);

    bool IsUserDecryptionAllowed(string identity);

    bool IsProtectionUnderLockRequired(string identity);

    event EventHandler<object> PolicyChanged;

    bool IsProtectionEnabled { get; }
  }
}
