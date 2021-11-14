// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.MobileNativeMethods
// Assembly: Microsoft.Xna.Framework.Game, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 6EBDB755-3EEE-4715-BDC3-9A6D92805A5E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB65~1.DLL

using System;
using System.Runtime.InteropServices;

namespace Microsoft.Xna.Framework
{
  internal static class MobileNativeMethods
  {
    [DllImport("SYSTEM", EntryPoint = "System_AlertableSleep")]
    internal static extern int AlertableSleep(int milliseconds);

    [DllImport("SYSTEM", EntryPoint = "System_ShouldQuit")]
    internal static extern int ShouldQuit(ref bool exit);

    [DllImport("SYSTEM", EntryPoint = "System_GetLockSwitchState")]
    internal static extern int GetLockSwitchState(ref bool exit);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint CreatePageHandle(int windowHandle);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern void GamePage_ReleaseHandle(uint handle);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern int GamePage_GetWindowHandle(uint handle);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint GamePage_GetClientBounds(
      uint handle,
      ref int left,
      ref int top,
      ref int width,
      ref int height,
      bool fullscreen);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern void GamePage_SetClientBounds(
      uint handle,
      int left,
      int top,
      int width,
      int height);

    [DllImport("kernelbase.dll")]
    internal static extern short QueryPerformanceCounter(ref long x);

    [DllImport("kernelbase.dll")]
    internal static extern bool QueryPerformanceFrequency(ref long x);

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "CUI_CreateTimer")]
    internal static extern uint CreateTimer(
      MsgTimerCallback timerEventHandler,
      ref IntPtr pGameLoopTickEventTimer);

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "CUI_SetRelativeTimer")]
    internal static extern uint SetRelativeTimer(
      IntPtr pGameLoopTickEventTimer,
      long initialTimeoutIn100nsUnits,
      long repeatedTimeoutIn100nsUnits);

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "CUI_CancelTimer")]
    internal static extern uint CancelTimer(IntPtr pGameLoopTickEventTimer);

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "CUI_ReleaseTimer")]
    internal static extern uint ReleaseTimer(IntPtr pGameLoopTickEventTimer);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint ShutdownInput();
  }
}
