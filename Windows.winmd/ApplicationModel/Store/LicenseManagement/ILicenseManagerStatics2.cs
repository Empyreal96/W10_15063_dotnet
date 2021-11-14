// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.LicenseManagement.ILicenseManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.LicenseManagement
{
  [Guid(2871968891, 8057, 17536, 184, 126, 44, 73, 158, 96, 27, 163)]
  [ExclusiveTo(typeof (LicenseManager))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ILicenseManagerStatics2
  {
    [RemoteAsync]
    IAsyncAction RefreshLicensesAsync(LicenseRefreshOption refreshOption);
  }
}
