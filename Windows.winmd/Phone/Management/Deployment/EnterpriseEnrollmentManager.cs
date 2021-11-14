// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Management.Deployment.EnterpriseEnrollmentManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Management.Deployment
{
  [WebHostHidden]
  [Static(typeof (IEnterpriseEnrollmentManager), 65536, "Windows.Phone.PhoneContract")]
  [ContractVersion(typeof (PhoneContract), 65536)]
  public static class EnterpriseEnrollmentManager
  {
    public static extern IVectorView<Enterprise> EnrolledEnterprises { [MethodImpl] get; }

    public static extern Enterprise CurrentEnterprise { [MethodImpl] get; }

    [MethodImpl]
    public static extern IAsyncAction ValidateEnterprisesAsync();

    [MethodImpl]
    public static extern IAsyncOperation<EnterpriseEnrollmentResult> RequestEnrollmentAsync(
      string enrollmentToken);

    [MethodImpl]
    public static extern IAsyncOperation<bool> RequestUnenrollmentAsync(
      Enterprise enterprise);
  }
}
