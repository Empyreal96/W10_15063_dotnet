// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountScopeManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Provider
{
  [Guid(1550639996, 4786, 16954, 191, 61, 133, 184, 215, 229, 54, 86)]
  [ExclusiveTo(typeof (WebAccountManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebAccountScopeManagerStatics
  {
    [RemoteAsync]
    [Overload("AddWebAccountWithScopeAsync")]
    IAsyncOperation<WebAccount> AddWebAccountAsync(
      string webAccountId,
      string webAccountUserName,
      IMapView<string, string> props,
      WebAccountScope scope);

    IAsyncAction SetScopeAsync(WebAccount webAccount, WebAccountScope scope);

    WebAccountScope GetScope(WebAccount webAccount);
  }
}
