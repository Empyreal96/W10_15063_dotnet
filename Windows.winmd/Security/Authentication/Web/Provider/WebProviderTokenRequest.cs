// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.WebProviderTokenRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Core;
using Windows.Security.Credentials;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace Windows.Security.Authentication.Web.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class WebProviderTokenRequest : IWebProviderTokenRequest, IWebProviderTokenRequest2
  {
    public extern WebTokenRequest ClientRequest { [MethodImpl] get; }

    public extern IVectorView<WebAccount> WebAccounts { [MethodImpl] get; }

    public extern WebAccountSelectionOptions WebAccountSelectionOptions { [MethodImpl] get; }

    public extern Uri ApplicationCallbackUri { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<CryptographicKey> GetApplicationTokenBindingKeyAsync(
      TokenBindingKeyType keyType,
      Uri target);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IBuffer> GetApplicationTokenBindingKeyIdAsync(
      TokenBindingKeyType keyType,
      Uri target);
  }
}
