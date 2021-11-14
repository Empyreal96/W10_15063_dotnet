// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.Storage.Streams;
using Windows.Web.Http;

namespace Windows.Security.Authentication.Web.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebAccountManager))]
  [Guid(3001606566, 54426, 16434, 132, 191, 26, 40, 71, 116, 123, 241)]
  internal interface IWebAccountManagerStatics
  {
    IAsyncAction UpdateWebAccountPropertiesAsync(
      WebAccount webAccount,
      string webAccountUserName,
      IMapView<string, string> additionalProperties);

    [Overload("AddWebAccountAsync")]
    [RemoteAsync]
    IAsyncOperation<WebAccount> AddWebAccountAsync(
      string webAccountId,
      string webAccountUserName,
      IMapView<string, string> props);

    IAsyncAction DeleteWebAccountAsync(WebAccount webAccount);

    [RemoteAsync]
    IAsyncOperation<IVectorView<WebAccount>> FindAllProviderWebAccountsAsync();

    [RemoteAsync]
    IAsyncAction PushCookiesAsync(Uri uri, IVectorView<HttpCookie> cookies);

    [RemoteAsync]
    IAsyncAction SetViewAsync(WebAccount webAccount, WebAccountClientView view);

    [RemoteAsync]
    IAsyncAction ClearViewAsync(WebAccount webAccount, Uri applicationCallbackUri);

    [RemoteAsync]
    IAsyncOperation<IVectorView<WebAccountClientView>> GetViewsAsync(
      WebAccount webAccount);

    IAsyncAction SetWebAccountPictureAsync(
      WebAccount webAccount,
      IRandomAccessStream webAccountPicture);

    IAsyncAction ClearWebAccountPictureAsync(WebAccount webAccount);
  }
}
