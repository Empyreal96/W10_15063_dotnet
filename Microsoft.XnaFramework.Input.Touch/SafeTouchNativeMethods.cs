// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.Touch.SafeTouchNativeMethods
// Assembly: Microsoft.Xna.Framework.Input.Touch, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 8E9BEFFA-058F-469C-A733-2CE9128BE180
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI3BB0~1.DLL

using MS.Internal;
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Xna.Framework.Input.Touch
{
  internal static class SafeTouchNativeMethods
  {
    internal const uint WM_GESTURE = 281;

    [SecuritySafeCritical]
    internal static void CopyGestureInfo(IntPtr lParam, ref TouchInfoBuffer touchInfo) => UnsafeTouchNativeMethods.CopyGestureInfo(lParam, ref touchInfo);

    [SecuritySafeCritical]
    internal static int SizeOf(Type t) => Marshal.SizeOf(t);

    [SecuritySafeCritical]
    internal static uint TouchSessionAdd(IntPtr handle, ref TouchInfoBuffer touch) => UnsafeTouchNativeMethods.TouchSessionAdd(handle, ref touch);

    [SecuritySafeCritical]
    internal static uint GamePage_GetClientBounds(
      uint handle,
      ref int left,
      ref int top,
      ref int width,
      ref int height,
      bool fullscreen)
    {
      return UnsafeTouchNativeMethods.GamePage_GetClientBounds(handle, ref left, ref top, ref width, ref height, fullscreen);
    }

    [SecuritySafeCritical]
    internal static uint CreateTouchSession(out IntPtr handle) => UnsafeTouchNativeMethods.CreateTouchSession(out handle);

    [SecuritySafeCritical]
    internal static uint TouchSessionReadConfigUInt(
      IntPtr handle,
      TouchSessionConfigSetting setting,
      out uint value)
    {
      return UnsafeTouchNativeMethods.TouchSessionReadConfigUInt(handle, setting, out value);
    }

    [SecuritySafeCritical]
    internal static uint TouchSessionSetExpected(IntPtr handle, GestureTypeInternal expected) => UnsafeTouchNativeMethods.TouchSessionSetExpected(handle, expected);

    [SecuritySafeCritical]
    internal static uint TouchSessionQueryPotentials(
      IntPtr handle,
      out GestureTypeInternal potentials)
    {
      return UnsafeTouchNativeMethods.TouchSessionQueryPotentials(handle, out potentials);
    }

    [SecuritySafeCritical]
    internal static uint TouchSessionRelease(IntPtr handle) => UnsafeTouchNativeMethods.TouchSessionRelease(handle);

    [SecuritySafeCritical]
    internal static uint EnsureTouchInputEndpoint()
    {
      bool isUnhosted = false;
      XcpImports.Host_GetIsXnaApplication(ref isUnhosted);
      uint num = UnsafeTouchNativeMethods.InitializeInput(isUnhosted);
      if (num == 0U)
      {
        IntPtr touchEndpoint;
        num = UnsafeTouchNativeMethods.GetTouchInputEndpoint(out touchEndpoint);
        if (num == 0U)
        {
          if (isUnhosted)
            XcpImports.Host_ReplaceTouchInputEndpoint(touchEndpoint);
          else
            XcpImports.Host_RegisterTouchInputHook(touchEndpoint);
        }
      }
      return num;
    }

    [SecuritySafeCritical]
    internal static uint EnsureTextInputEndpoint()
    {
      bool isUnhosted = false;
      XcpImports.Host_GetIsXnaApplication(ref isUnhosted);
      uint num = UnsafeTouchNativeMethods.InitializeInput(isUnhosted);
      if (num == 0U)
      {
        IntPtr textEndpoint;
        num = UnsafeTouchNativeMethods.GetTextInputEndpoint(out textEndpoint);
        if (num == 0U)
          XcpImports.Host_ReplaceTextInputEndpoint(textEndpoint);
      }
      return num;
    }

    [SecuritySafeCritical]
    internal static uint RegisterTouchCallback(ProcessTouchInfoDelegate processTouchInfoDelegate) => UnsafeTouchNativeMethods.RegisterTouchCallback(processTouchInfoDelegate);

    [SecuritySafeCritical]
    internal static uint CreateFilterSession(out IntPtr handle) => UnsafeTouchNativeMethods.CreateFilterSession(out handle);

    [SecuritySafeCritical]
    internal static uint FilterSessionFilter(IntPtr handle, ref TouchInfoBuffer touch) => UnsafeTouchNativeMethods.FilterSessionFilter(handle, ref touch);

    [SecuritySafeCritical]
    internal static uint FilterSessionRelease(IntPtr handle) => UnsafeTouchNativeMethods.FilterSessionRelease(handle);
  }
}
