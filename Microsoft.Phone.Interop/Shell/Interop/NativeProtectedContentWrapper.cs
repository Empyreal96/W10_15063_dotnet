// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.Interop.NativeProtectedContentWrapper
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System.Security;

namespace Microsoft.Phone.Shell.Interop
{
  [SecuritySafeCritical]
  internal class NativeProtectedContentWrapper
  {
    public static bool IsScreenCaptureEnabled
    {
      get
      {
        bool pResult = false;
        if (ApplicationHost.Current.RootTask.AppChromeHandle != null)
          NativeProtectedContent.GetIsShowingProtectedContent(ApplicationHost.Current.RootTask.AppChromeHandle, out pResult);
        return !pResult;
      }
      set
      {
        if (ApplicationHost.Current.RootTask.AppChromeHandle == null)
          return;
        NativeProtectedContent.SetIsShowingProtectedContent(ApplicationHost.Current.RootTask.AppChromeHandle, !value);
      }
    }

    public static bool IsMaximized
    {
      get
      {
        bool pResult = false;
        if (ApplicationHost.Current.RootTask.AppChromeHandle != null)
          NativeProtectedContent.GetIsMaximized(ApplicationHost.Current.RootTask.AppChromeHandle, out pResult);
        return pResult;
      }
      set
      {
        if (ApplicationHost.Current.RootTask.AppChromeHandle == null)
          return;
        NativeProtectedContent.SetIsMaximized(ApplicationHost.Current.RootTask.AppChromeHandle, value);
      }
    }
  }
}
