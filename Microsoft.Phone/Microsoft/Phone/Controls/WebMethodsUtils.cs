// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.WebMethodsUtils
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Microsoft.Phone.Controls
{
  [SecurityCritical]
  internal class WebMethodsUtils
  {
    internal const int INTERNET_COOKIE_HTTPONLY = 8192;

    [DllImport("WinInet", CharSet = CharSet.Unicode, SetLastError = true)]
    internal static extern bool InternetGetCookieExW(
      [MarshalAs(UnmanagedType.LPWStr)] string lpszUrl,
      [MarshalAs(UnmanagedType.LPWStr)] string lpszCookieName,
      StringBuilder lpszCookieData,
      ref int lpdwSize,
      int dwFlags,
      IntPtr lpReserved);

    [DllImport("iemobileutil.dll")]
    internal static extern int DeleteCacheCookies();

    [DllImport("iemobileutil.dll")]
    internal static extern int DeleteInternetCache();
  }
}
