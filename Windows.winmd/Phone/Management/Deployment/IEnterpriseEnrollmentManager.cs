// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Management.Deployment.IEnterpriseEnrollmentManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Management.Deployment
{
  [ExclusiveTo(typeof (EnterpriseEnrollmentManager))]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(553251728, 11369, 16856, 136, 230, 228, 179, 136, 64, 38, 203)]
  [WebHostHidden]
  internal interface IEnterpriseEnrollmentManager
  {
    IVectorView<Enterprise> EnrolledEnterprises { get; }

    Enterprise CurrentEnterprise { get; }

    IAsyncAction ValidateEnterprisesAsync();

    IAsyncOperation<EnterpriseEnrollmentResult> RequestEnrollmentAsync(
      string enrollmentToken);

    IAsyncOperation<bool> RequestUnenrollmentAsync(Enterprise enterprise);
  }
}
