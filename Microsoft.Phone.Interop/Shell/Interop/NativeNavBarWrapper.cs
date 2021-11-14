// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.Interop.NativeNavBarWrapper
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System.Runtime.InteropServices;
using System.Windows;

namespace Microsoft.Phone.Shell.Interop
{
  internal static class NativeNavBarWrapper
  {
    internal static bool IsVisible
    {
      get
      {
        bool pVisible = false;
        if (ApplicationHost.Current.RootTask.AppChromeHandle != null)
          NativeNavBarWrapper.GetIsNavBarVisible(ApplicationHost.Current.RootTask.AppChromeHandle, out pVisible);
        return pVisible;
      }
    }

    internal static double Height
    {
      get
      {
        double num = 0.0;
        if (ApplicationHost.Current.RootTask.AppChromeHandle != null)
        {
          uint pHeight;
          NativeNavBarWrapper.GetNavBarHeight(ApplicationHost.Current.RootTask.AppChromeHandle, out pHeight);
          num = (double) pHeight * 100.0 / (double) Application.Current.Host.Content.ActualScaleFactor;
        }
        return num;
      }
    }

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void GetIsNavBarVisible(
      SafeAppChromeHandle pAppChrome,
      [MarshalAs(UnmanagedType.U1)] out bool pVisible);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void GetNavBarHeight(SafeAppChromeHandle pAppChrome, out uint pHeight);
  }
}
