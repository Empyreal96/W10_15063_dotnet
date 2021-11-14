// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebProviderTokenRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Core;
using Windows.Security.Credentials;
using Windows.Security.Cryptography.Core;

namespace Windows.Security.Authentication.Web.Provider
{
  [Guid(504919947, 34821, 17739, 159, 17, 70, 141, 42, 241, 9, 90)]
  [ExclusiveTo(typeof (WebProviderTokenRequest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebProviderTokenRequest
  {
    WebTokenRequest ClientRequest { get; }

    IVectorView<WebAccount> WebAccounts { get; }

    WebAccountSelectionOptions WebAccountSelectionOptions { get; }

    Uri ApplicationCallbackUri { get; }

    [RemoteAsync]
    IAsyncOperation<CryptographicKey> GetApplicationTokenBindingKeyAsync(
      TokenBindingKeyType keyType,
      Uri target);
  }
}
