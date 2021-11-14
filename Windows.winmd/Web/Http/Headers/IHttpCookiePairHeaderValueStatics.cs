// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpCookiePairHeaderValueStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpCookiePairHeaderValue))]
  [Guid(1854303560, 1711, 17506, 129, 88, 153, 56, 141, 93, 202, 129)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpCookiePairHeaderValueStatics
  {
    HttpCookiePairHeaderValue Parse(string input);

    bool TryParse(
      string input,
      out HttpCookiePairHeaderValue cookiePairHeaderValue);
  }
}
