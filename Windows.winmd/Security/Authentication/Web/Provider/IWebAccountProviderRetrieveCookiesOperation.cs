// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountProviderRetrieveCookiesOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Web.Http;

namespace Windows.Security.Authentication.Web.Provider
{
  [ExclusiveTo(typeof (WebAccountProviderRetrieveCookiesOperation))]
  [Guid(1510212673, 4003, 19121, 160, 28, 32, 177, 16, 53, 133, 148)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebAccountProviderRetrieveCookiesOperation : IWebAccountProviderOperation
  {
    Uri Context { get; }

    IVector<HttpCookie> Cookies { get; }

    Uri Uri { set; get; }

    Uri ApplicationCallbackUri { get; }
  }
}
