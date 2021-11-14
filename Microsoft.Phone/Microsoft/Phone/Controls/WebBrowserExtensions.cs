// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.WebBrowserExtensions
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Phone.Controls
{
  public static class WebBrowserExtensions
  {
    [SecuritySafeCritical]
    public static CookieCollection GetCookies(this WebBrowser browserControl)
    {
      int lpdwSize = 0;
      int dwFlags = 8192;
      CookieCollection cookieCollection = new CookieCollection();
      int startIndex = 0;
      Uri uri = new Uri("about:blank");
      Uri url = browserControl != null ? browserControl.Source : throw new ArgumentNullException(nameof (browserControl));
      string lpszUrl = url != (Uri) null && url != uri ? url.OriginalString : throw new InvalidOperationException(LocalizeString.InvalidWebBrowserSourceUrl);
      if (WebMethodsUtils.InternetGetCookieExW(lpszUrl, (string) null, (StringBuilder) null, ref lpdwSize, dwFlags, IntPtr.Zero) && lpdwSize != 0)
      {
        StringBuilder lpszCookieData = new StringBuilder(lpdwSize);
        int num;
        if (WebMethodsUtils.InternetGetCookieExW(lpszUrl, (string) null, lpszCookieData, ref lpdwSize, dwFlags, IntPtr.Zero) && lpdwSize != 0)
        {
          for (; startIndex < lpszCookieData.Length; startIndex = num + 1)
          {
            Cookie cookie = new Cookie(WebBrowserExtensions.GetCookieName(lpszCookieData.ToString(), startIndex).Trim(), WebBrowserExtensions.GetCookieValue(lpszCookieData.ToString(), startIndex).Trim());
            WebBrowserExtensions.SetCookieProperties(cookie, url);
            cookieCollection.Add(cookie);
            num = lpszCookieData.ToString().IndexOf(';', startIndex);
            if (num == -1)
              break;
          }
        }
      }
      return cookieCollection;
    }

    [SecuritySafeCritical]
    public static Task ClearCookiesAsync(this WebBrowser browserControl) => (Task) Task.Factory.StartNew<int>((Func<M0>) (() => WebMethodsUtils.DeleteCacheCookies()));

    [SecuritySafeCritical]
    public static Task ClearInternetCacheAsync(this WebBrowser browserControl) => (Task) Task.Factory.StartNew<int>((Func<M0>) (() => WebMethodsUtils.DeleteInternetCache()));

    private static void SetCookieProperties(Cookie cookie, Uri url)
    {
      cookie.Domain = url.DnsSafeHost;
      cookie.Secure = url.Scheme == Uri.UriSchemeHttps;
      cookie.Expired = false;
    }

    private static string GetCookieName(string str, int startIndex) => str.Substring(startIndex, str.IndexOf('=', startIndex) - startIndex);

    private static string GetCookieValue(string str, int startIndex)
    {
      int startIndex1 = str.IndexOf('=', startIndex) + 1;
      return str.IndexOf(';', startIndex1) != -1 ? str.Substring(startIndex1, str.IndexOf(';', startIndex1) - startIndex1) : str.Substring(startIndex1, str.Length - startIndex1);
    }
  }
}
