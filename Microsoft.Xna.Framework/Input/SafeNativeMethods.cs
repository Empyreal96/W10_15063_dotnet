// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.SafeNativeMethods
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using MS.Internal;
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Xna.Framework.Input
{
  internal static class SafeNativeMethods
  {
    [SecuritySafeCritical]
    public static IntPtr GetFunctionPointerForDelegate(Delegate d) => Marshal.GetFunctionPointerForDelegate(d);

    [SecuritySafeCritical]
    internal static int GamePage_GetWindowHandle(uint handle) => UnsafeNativeMethods.GamePage_GetWindowHandle(handle);

    [SecuritySafeCritical]
    internal static int SHSetImeMode(int hwnd, int imeMode) => UnsafeNativeMethods.SHSetImeMode(hwnd, imeMode);

    [SecuritySafeCritical]
    internal static uint EnsureTouchInputEndpoint()
    {
      bool isUnhosted = false;
      XcpImports.Host_GetIsXnaApplication(ref isUnhosted);
      uint num = UnsafeNativeMethods.InitializeInput(isUnhosted);
      if (num == 0U)
      {
        IntPtr touchEndpoint;
        num = UnsafeNativeMethods.GetTouchInputEndpoint(out touchEndpoint);
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
      uint num = UnsafeNativeMethods.InitializeInput(isUnhosted);
      if (num == 0U)
      {
        IntPtr textEndpoint;
        num = UnsafeNativeMethods.GetTextInputEndpoint(out textEndpoint);
        if (num == 0U)
          XcpImports.Host_ReplaceTextInputEndpoint(textEndpoint);
      }
      return num;
    }

    [SecuritySafeCritical]
    internal static uint RegisterTextCallback(ProcessTextInputDelegate processTextInputDelegate) => UnsafeNativeMethods.RegisterTextCallback(processTextInputDelegate);
  }
}
