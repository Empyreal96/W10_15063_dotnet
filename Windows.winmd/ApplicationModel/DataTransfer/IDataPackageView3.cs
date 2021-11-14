// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataPackageView3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.EnterpriseData;

namespace Windows.ApplicationModel.DataTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DataPackageView))]
  [Guid(3547820456, 56749, 17032, 132, 40, 209, 202, 227, 148, 18, 139)]
  internal interface IDataPackageView3
  {
    [Overload("RequestAccessAsync")]
    IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessAsync();

    [Overload("RequestAccessWithEnterpriseIdAsync")]
    IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessAsync(
      string enterpriseId);

    ProtectionPolicyEvaluationResult UnlockAndAssumeEnterpriseIdentity();
  }
}
