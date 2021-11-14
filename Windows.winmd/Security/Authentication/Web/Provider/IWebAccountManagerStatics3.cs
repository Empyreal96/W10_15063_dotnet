// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountManagerStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.System;

namespace Windows.Security.Authentication.Web.Provider
{
  [Guid(3712295846, 35407, 19106, 177, 94, 3, 245, 80, 175, 19, 89)]
  [ExclusiveTo(typeof (WebAccountManager))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IWebAccountManagerStatics3
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<WebAccount>> FindAllProviderWebAccountsForUserAsync(
      User user);

    [RemoteAsync]
    [Overload("AddWebAccountForUserAsync")]
    IAsyncOperation<WebAccount> AddWebAccountForUserAsync(
      User user,
      string webAccountId,
      string webAccountUserName,
      IMapView<string, string> props);

    [Overload("AddWebAccountWithScopeForUserAsync")]
    [RemoteAsync]
    IAsyncOperation<WebAccount> AddWebAccountForUserAsync(
      User user,
      string webAccountId,
      string webAccountUserName,
      IMapView<string, string> props,
      WebAccountScope scope);

    [Overload("AddWebAccountWithScopeAndMapForUserAsync")]
    [RemoteAsync]
    IAsyncOperation<WebAccount> AddWebAccountForUserAsync(
      User user,
      string webAccountId,
      string webAccountUserName,
      IMapView<string, string> props,
      WebAccountScope scope,
      string perUserWebAccountId);
  }
}
