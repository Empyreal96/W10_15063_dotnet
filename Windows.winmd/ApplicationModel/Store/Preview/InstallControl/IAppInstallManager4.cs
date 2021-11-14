// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallManager4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [Guid(638200342, 23198, 20157, 185, 68, 242, 186, 117, 195, 17, 89)]
  [ExclusiveTo(typeof (AppInstallManager))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IAppInstallManager4
  {
    [RemoteAsync]
    IAsyncOperation<GetEntitlementResult> GetFreeUserEntitlementAsync(
      string storeId,
      string campaignId,
      string correlationVector);

    [RemoteAsync]
    IAsyncOperation<GetEntitlementResult> GetFreeUserEntitlementForUserAsync(
      User user,
      string storeId,
      string campaignId,
      string correlationVector);

    [RemoteAsync]
    IAsyncOperation<GetEntitlementResult> GetFreeDeviceEntitlementAsync(
      string storeId,
      string campaignId,
      string correlationVector);
  }
}
