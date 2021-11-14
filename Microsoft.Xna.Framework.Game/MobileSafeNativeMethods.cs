// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.MobileSafeNativeMethods
// Assembly: Microsoft.Xna.Framework.Game, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 6EBDB755-3EEE-4715-BDC3-9A6D92805A5E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB65~1.DLL

using System.Security;

namespace Microsoft.Xna.Framework
{
  internal static class MobileSafeNativeMethods
  {
    [SecuritySafeCritical]
    internal static uint CreatePageHandle(int windowHandle) => MobileNativeMethods.CreatePageHandle(windowHandle);

    [SecuritySafeCritical]
    internal static void GamePage_ReleaseHandle(uint handle) => MobileNativeMethods.GamePage_ReleaseHandle(handle);

    [SecuritySafeCritical]
    internal static int GamePage_GetWindowHandle(uint handle) => MobileNativeMethods.GamePage_GetWindowHandle(handle);

    [SecuritySafeCritical]
    internal static uint GamePage_GetClientBounds(
      uint handle,
      ref int left,
      ref int top,
      ref int width,
      ref int height,
      bool fullscreen)
    {
      return MobileNativeMethods.GamePage_GetClientBounds(handle, ref left, ref top, ref width, ref height, fullscreen);
    }

    [SecuritySafeCritical]
    internal static void GamePage_SetClientBounds(
      uint handle,
      int left,
      int top,
      int width,
      int height)
    {
      MobileNativeMethods.GamePage_SetClientBounds(handle, left, top, width, height);
    }

    [SecuritySafeCritical]
    internal static short QueryPerformanceCounter(ref long x) => MobileNativeMethods.QueryPerformanceCounter(ref x);

    [SecuritySafeCritical]
    internal static bool QueryPerformanceFrequency(ref long x) => MobileNativeMethods.QueryPerformanceFrequency(ref x);

    [SecuritySafeCritical]
    internal static uint ShutdownInput() => MobileNativeMethods.ShutdownInput();
  }
}
