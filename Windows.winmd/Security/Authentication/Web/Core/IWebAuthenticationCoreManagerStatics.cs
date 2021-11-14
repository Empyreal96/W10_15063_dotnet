// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebAuthenticationCoreManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebAuthenticationCoreManager))]
  [Guid(1791655058, 42369, 17529, 156, 16, 117, 46, 255, 68, 253, 52)]
  internal interface IWebAuthenticationCoreManagerStatics
  {
    [Overload("GetTokenSilentlyAsync")]
    [RemoteAsync]
    IAsyncOperation<WebTokenRequestResult> GetTokenSilentlyAsync(
      WebTokenRequest request);

    [Overload("GetTokenSilentlyWithWebAccountAsync")]
    [RemoteAsync]
    IAsyncOperation<WebTokenRequestResult> GetTokenSilentlyAsync(
      WebTokenRequest request,
      WebAccount webAccount);

    [Overload("RequestTokenAsync")]
    [RemoteAsync]
    IAsyncOperation<WebTokenRequestResult> RequestTokenAsync(
      WebTokenRequest request);

    [Overload("RequestTokenWithWebAccountAsync")]
    [RemoteAsync]
    IAsyncOperation<WebTokenRequestResult> RequestTokenAsync(
      WebTokenRequest request,
      WebAccount webAccount);

    [RemoteAsync]
    IAsyncOperation<WebAccount> FindAccountAsync(
      WebAccountProvider provider,
      string webAccountId);

    [RemoteAsync]
    [Overload("FindAccountProviderAsync")]
    IAsyncOperation<WebAccountProvider> FindAccountProviderAsync(
      string webAccountProviderId);

    [Overload("FindAccountProviderWithAuthorityAsync")]
    [RemoteAsync]
    IAsyncOperation<WebAccountProvider> FindAccountProviderAsync(
      string webAccountProviderId,
      string authority);
  }
}
