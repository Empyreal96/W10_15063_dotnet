// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.WebBrowserExceptionHelper
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using Microsoft.Phone.Interop;
using System;
using System.Globalization;

namespace Microsoft.Phone.Controls
{
  internal static class WebBrowserExceptionHelper
  {
    public static Exception GetUriArgumentException() => (Exception) new ArgumentException(Resources.UriArgumentException);

    public static Exception GetNativeExistsException() => (Exception) new InvalidOperationException(Resources.NativeExistsException);

    public static Exception GetUnknownHResultException(int hr) => (Exception) new SystemException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, Resources.UnknownHResultException, (object) hr));

    public static Exception GetBusyException() => (Exception) new InvalidOperationException(Resources.BusyException);

    public static Exception GetThreadAccessException() => (Exception) new UnauthorizedAccessException(Resources.ThreadAccessException);

    public static Exception GetIllegalReentrancyException() => (Exception) new InvalidOperationException(Resources.IllegalReentrancyException);
  }
}
