// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebTokenRequestFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Core
{
  [Guid(1827804188, 4080, 19559, 184, 79, 153, 221, 190, 74, 114, 201)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebTokenRequest))]
  internal interface IWebTokenRequestFactory
  {
    WebTokenRequest Create(
      WebAccountProvider provider,
      string scope,
      string clientId);

    WebTokenRequest CreateWithPromptType(
      WebAccountProvider provider,
      string scope,
      string clientId,
      WebTokenRequestPromptType promptType);

    WebTokenRequest CreateWithProvider(WebAccountProvider provider);

    WebTokenRequest CreateWithScope(WebAccountProvider provider, string scope);
  }
}
