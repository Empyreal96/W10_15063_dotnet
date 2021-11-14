// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.WebAccountManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.Storage.Streams;
using Windows.System;
using Windows.Web.Http;

namespace Windows.Security.Authentication.Web.Provider
{
  [Static(typeof (IWebAccountManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IWebAccountScopeManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IWebAccountMapManagerStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IWebAccountManagerStatics3), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IWebAccountManagerStatics2), 131072, "Windows.Foundation.UniversalApiContract")]
  public static class WebAccountManager
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<WebAccount>> FindAllProviderWebAccountsForUserAsync(
      User user);

    [RemoteAsync]
    [Overload("AddWebAccountForUserAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccount> AddWebAccountForUserAsync(
      User user,
      string webAccountId,
      string webAccountUserName,
      IMapView<string, string> props);

    [Overload("AddWebAccountWithScopeForUserAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccount> AddWebAccountForUserAsync(
      User user,
      string webAccountId,
      string webAccountUserName,
      IMapView<string, string> props,
      WebAccountScope scope);

    [Overload("AddWebAccountWithScopeAndMapForUserAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccount> AddWebAccountForUserAsync(
      User user,
      string webAccountId,
      string webAccountUserName,
      IMapView<string, string> props,
      WebAccountScope scope,
      string perUserWebAccountId);

    [RemoteAsync]
    [Overload("AddWebAccountWithScopeAndMapAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccount> AddWebAccountAsync(
      string webAccountId,
      string webAccountUserName,
      IMapView<string, string> props,
      WebAccountScope scope,
      string perUserWebAccountId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction SetPerAppToPerUserAccountAsync(
      WebAccount perAppAccount,
      string perUserWebAccountId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccount> GetPerUserFromPerAppAccountAsync(
      WebAccount perAppAccount);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ClearPerUserFromPerAppAccountAsync(
      WebAccount perAppAccount);

    [RemoteAsync]
    [Overload("AddWebAccountWithScopeAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccount> AddWebAccountAsync(
      string webAccountId,
      string webAccountUserName,
      IMapView<string, string> props,
      WebAccountScope scope);

    [MethodImpl]
    public static extern IAsyncAction SetScopeAsync(
      WebAccount webAccount,
      WebAccountScope scope);

    [MethodImpl]
    public static extern WebAccountScope GetScope(WebAccount webAccount);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction PullCookiesAsync(
      string uriString,
      string callerPFN);

    [MethodImpl]
    public static extern IAsyncAction UpdateWebAccountPropertiesAsync(
      WebAccount webAccount,
      string webAccountUserName,
      IMapView<string, string> additionalProperties);

    [RemoteAsync]
    [Overload("AddWebAccountAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccount> AddWebAccountAsync(
      string webAccountId,
      string webAccountUserName,
      IMapView<string, string> props);

    [MethodImpl]
    public static extern IAsyncAction DeleteWebAccountAsync(WebAccount webAccount);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<WebAccount>> FindAllProviderWebAccountsAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction PushCookiesAsync(
      Uri uri,
      IVectorView<HttpCookie> cookies);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction SetViewAsync(
      WebAccount webAccount,
      WebAccountClientView view);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ClearViewAsync(
      WebAccount webAccount,
      Uri applicationCallbackUri);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<WebAccountClientView>> GetViewsAsync(
      WebAccount webAccount);

    [MethodImpl]
    public static extern IAsyncAction SetWebAccountPictureAsync(
      WebAccount webAccount,
      IRandomAccessStream webAccountPicture);

    [MethodImpl]
    public static extern IAsyncAction ClearWebAccountPictureAsync(WebAccount webAccount);
  }
}
