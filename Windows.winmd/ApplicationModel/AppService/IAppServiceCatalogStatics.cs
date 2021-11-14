// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.IAppServiceCatalogStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4010616071, 53554, 19589, 131, 149, 60, 49, 213, 161, 233, 65)]
  [ExclusiveTo(typeof (AppServiceCatalog))]
  internal interface IAppServiceCatalogStatics
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<AppInfo>> FindAppServiceProvidersAsync(
      string appServiceName);
  }
}
