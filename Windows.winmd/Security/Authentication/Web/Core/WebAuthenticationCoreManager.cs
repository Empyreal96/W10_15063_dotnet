// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.WebAuthenticationCoreManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.System;

namespace Windows.Security.Authentication.Web.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IWebAuthenticationCoreManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IWebAuthenticationCoreManagerStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IWebAuthenticationCoreManagerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class WebAuthenticationCoreManager
  {
    [MethodImpl]
    public static extern WebAccountMonitor CreateWebAccountMonitor(
      IIterable<WebAccount> webAccounts);

    [Overload("FindAccountProviderWithAuthorityForUserAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccountProvider> FindAccountProviderAsync(
      string webAccountProviderId,
      string authority,
      User user);

    [RemoteAsync]
    [Overload("GetTokenSilentlyAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WebTokenRequestResult> GetTokenSilentlyAsync(
      WebTokenRequest request);

    [Overload("GetTokenSilentlyWithWebAccountAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WebTokenRequestResult> GetTokenSilentlyAsync(
      WebTokenRequest request,
      WebAccount webAccount);

    [RemoteAsync]
    [Overload("RequestTokenAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WebTokenRequestResult> RequestTokenAsync(
      WebTokenRequest request);

    [Overload("RequestTokenWithWebAccountAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WebTokenRequestResult> RequestTokenAsync(
      WebTokenRequest request,
      WebAccount webAccount);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccount> FindAccountAsync(
      WebAccountProvider provider,
      string webAccountId);

    [RemoteAsync]
    [Overload("FindAccountProviderAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccountProvider> FindAccountProviderAsync(
      string webAccountProviderId);

    [RemoteAsync]
    [Overload("FindAccountProviderWithAuthorityAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccountProvider> FindAccountProviderAsync(
      string webAccountProviderId,
      string authority);
  }
}
