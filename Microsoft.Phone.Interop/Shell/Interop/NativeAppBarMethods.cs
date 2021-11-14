// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.Interop.NativeAppBarMethods
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Shell.Interop
{
  [SecurityCritical]
  internal class NativeAppBarMethods
  {
    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void CreateAppBar(SafeAppChromeHandle pAppChrome, out IntPtr pAppBar);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void ReleaseAppBar(ref IntPtr pAppBar);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void SetAppBarOpacity(IntPtr pAppBar, float flOpacity);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void SetAppBarBackgroundColor(IntPtr pAppBar, uint clrBackground);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void SetAppBarForegroundColor(IntPtr pAppBar, uint clrForeground);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void SetAppBarMode(IntPtr pAppBar, [MarshalAs(UnmanagedType.I4)] ApplicationBarMode eMode);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void SetAppBarVisible(IntPtr pAppBar, [MarshalAs(UnmanagedType.U1)] bool fVisible);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void SetAppBarMenuEnabled(IntPtr pAppBar, [MarshalAs(UnmanagedType.U1)] bool fEnabled);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void SetVisibleAppBar(
      SafeAppChromeHandle pAppChrome,
      IntPtr pAppBar,
      SafeMenuListenerHandle pMenuListener);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void GetApplicationBarHeight([MarshalAs(UnmanagedType.I4)] ApplicationBarMode eMode, out int height);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static extern void GetAppBarEnabled(IntPtr pAppBar, [MarshalAs(UnmanagedType.U1)] out bool pResult);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static extern void GetAppBarMenuEnabled(IntPtr pAppBar, [MarshalAs(UnmanagedType.U1)] out bool pResult);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static extern void GetAppBarVisible(IntPtr pAppBar, [MarshalAs(UnmanagedType.U1)] out bool pResult);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void GetAppBarBackgroundColor(IntPtr pAppBar, out uint pResult);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void GetAppBarForegroundColor(IntPtr pAppBaruint, out uint pRes);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void GetAppBarOpacity(IntPtr pAppBar, out float pResult);
  }
}
