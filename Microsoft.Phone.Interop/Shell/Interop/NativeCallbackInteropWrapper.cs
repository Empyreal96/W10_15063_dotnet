// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.Interop.NativeCallbackInteropWrapper
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using Microsoft.Phone.Interop.Logging;
using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows;

namespace Microsoft.Phone.Shell.Interop
{
  [SecuritySafeCritical]
  internal class NativeCallbackInteropWrapper
  {
    private AppBarCallbackInfo mManagedCallbacks;
    public InteropCommandCallback cmdcallback;
    public InteropEnterMenuCallback onentermenu;
    public InteropExitMenuCallback onexitmenu;
    private AppBarCallbackFunctionPointers mInteropFunctionPointers;
    private SafeMenuListenerHandle mMenuListenerHandle;

    internal SafeMenuListenerHandle MenuListenerHandle => this.mMenuListenerHandle;

    internal NativeCallbackInteropWrapper(AppBarCallbackInfo callbacks)
    {
      this.mManagedCallbacks = callbacks;
      this.cmdcallback = new InteropCommandCallback(this.OnCommand);
      this.onentermenu = new InteropEnterMenuCallback(this.OnEnterMenu);
      this.onexitmenu = new InteropExitMenuCallback(this.OnExitMenu);
      this.mInteropFunctionPointers = new AppBarCallbackFunctionPointers();
      this.mInteropFunctionPointers.cmdcallback = Marshal.GetFunctionPointerForDelegate((Delegate) this.cmdcallback);
      this.mInteropFunctionPointers.onentermenu = Marshal.GetFunctionPointerForDelegate((Delegate) this.onentermenu);
      this.mInteropFunctionPointers.onexitmenu = Marshal.GetFunctionPointerForDelegate((Delegate) this.onexitmenu);
      NativeCallbackMethods.CreateMenuListener(out this.mMenuListenerHandle, ref this.mInteropFunctionPointers);
    }

    [SecurityCritical]
    [AllowReversePInvokeCalls]
    private void OnCommand(uint idCommand, bool isButton)
    {
      try
      {
        this.mManagedCallbacks.cmdcallback(idCommand, isButton);
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    [SecurityCritical]
    [AllowReversePInvokeCalls]
    private void OnEnterMenu()
    {
      Logger.YLogEvent(2147483665U, 9U, LogFlags.None, "");
      try
      {
        this.mManagedCallbacks.onentermenu();
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    [SecurityCritical]
    [AllowReversePInvokeCalls]
    private void OnExitMenu()
    {
      Logger.YLogEvent(2147483665U, 10U, LogFlags.None, "");
      try
      {
        this.mManagedCallbacks.onexitmenu();
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }
  }
}
