// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.Interop.NativeSystemTrayMethods
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
  internal class NativeSystemTrayMethods
  {
    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void CreateSystemTray(
      SafeAppChromeHandle pAppChrome,
      out IntPtr ppSysTray);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void ReleaseSystemTray(ref IntPtr pSysTray);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void SetSysTrayOpacity(IntPtr pSysTray, float fltOpacity);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void SetSysTrayForegroundColor(IntPtr pSysTray, uint cr);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void SetSysTrayBackgroundColor(IntPtr pSysTray, uint cr);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void SetSysTrayUseDefaultForegroundColor(
      IntPtr pSysTray,
      [MarshalAs(UnmanagedType.U1)] bool fUseDefaultForegroundColor);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void SetSysTrayUseDefaultBackgroundColor(
      IntPtr pSysTray,
      [MarshalAs(UnmanagedType.U1)] bool fUseDefaultBackgroundColor);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void SetSysTrayVisible(IntPtr pSysTray, [MarshalAs(UnmanagedType.Bool)] bool fVisible);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void SetVisibleSysTray(SafeAppChromeHandle pAppChrome, IntPtr pSysTray);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void GetSystemTrayHeight(Orientations orientation, out int height);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void GetVisibleRegion(
      SafeAppChromeHandle pAppChrome,
      Orientations orientation,
      out RECT rcVisibleRegion,
      out RECT rcClientRegion);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void GetMinimizedOverlayVisibleRegion(
      SafeAppChromeHandle pAppChrome,
      out RECT rcClientRegion);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void SetProgressIndicatorIsVisible(
      SafeAppChromeHandle pAppChrome,
      [MarshalAs(UnmanagedType.U1)] bool fIsVisible);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void SetProgressIndicatorIsIndeterminate(
      SafeAppChromeHandle pAppChrome,
      [MarshalAs(UnmanagedType.U1)] bool fIsIndeterminate);

    [DllImport("AppChromeAPI.dll", CharSet = CharSet.Auto, PreserveSig = false)]
    internal static extern void SetProgressIndicatorText(
      SafeAppChromeHandle pAppChrome,
      string pszText);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void SetProgressIndicatorPosition(
      SafeAppChromeHandle pAppChrome,
      [MarshalAs(UnmanagedType.R4)] float flValue);
  }
}
