// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpCookieManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [ExclusiveTo(typeof (HttpCookieManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2051217280, 52559, 20055, 168, 74, 91, 10, 83, 214, 187, 150)]
  internal interface IHttpCookieManager
  {
    [Overload("SetCookie")]
    bool SetCookie(HttpCookie cookie);

    [Overload("SetCookieWithThirdParty")]
    bool SetCookie(HttpCookie cookie, bool thirdParty);

    void DeleteCookie(HttpCookie cookie);

    HttpCookieCollection GetCookies(Uri uri);
  }
}
