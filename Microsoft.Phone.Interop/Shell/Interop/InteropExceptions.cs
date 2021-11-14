// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.Interop.InteropExceptions
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using Microsoft.Phone.Interop;
using System;
using System.Globalization;

namespace Microsoft.Phone.Shell.Interop
{
  internal static class InteropExceptions
  {
    private const int E_INVALIDARG = -2147024890;
    private const int E_PAGESTACKCANCELED = -2147220992;
    private const int E_NAVIGATEWHILEBACKGROUND = -2147220990;
    private const int E_NAVIGATEWITHCHILD = -2147220989;

    internal static Exception GetExceptionForHR(int hr)
    {
      switch (hr)
      {
        case -2147220992:
          return (Exception) new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, ShellResources.PageStackCanceled, (object) hr));
        case -2147220990:
        case -2147220989:
          return (Exception) new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, ShellResources.NavigateWhileInBackground, (object) hr));
        case -2147024890:
          return (Exception) new ArgumentException(ShellResources.InvalidArgument);
        default:
          return (Exception) new SystemException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, ShellResources.GeneralError, (object) hr));
      }
    }
  }
}
