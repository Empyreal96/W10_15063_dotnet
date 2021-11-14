// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountMapManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Provider
{
  [Guid(3908715631, 14875, 18596, 142, 144, 30, 89, 202, 111, 84, 219)]
  [ExclusiveTo(typeof (WebAccountManager))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IWebAccountMapManagerStatics
  {
    [Overload("AddWebAccountWithScopeAndMapAsync")]
    [RemoteAsync]
    IAsyncOperation<WebAccount> AddWebAccountAsync(
      string webAccountId,
      string webAccountUserName,
      IMapView<string, string> props,
      WebAccountScope scope,
      string perUserWebAccountId);

    [RemoteAsync]
    IAsyncAction SetPerAppToPerUserAccountAsync(
      WebAccount perAppAccount,
      string perUserWebAccountId);

    [RemoteAsync]
    IAsyncOperation<WebAccount> GetPerUserFromPerAppAccountAsync(
      WebAccount perAppAccount);

    [RemoteAsync]
    IAsyncAction ClearPerUserFromPerAppAccountAsync(WebAccount perAppAccount);
  }
}
