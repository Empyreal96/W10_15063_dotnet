// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.NativeIdleBehavior
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

namespace Microsoft.Phone.Shell
{
  internal class NativeIdleBehavior
  {
    private const uint k_lockPreventionPeriod = 20000;
    private const uint k_screenTimeOutOverLockPreventionPeriod = 4000;
    private Timer preventLockTimer;
    private object mLock = new object();
    private PhoneApplicationService phoneAppService;
    private bool mIsUserIdleEnabled;

    internal NativeIdleBehavior(PhoneApplicationService phoneApplicationService) => this.phoneAppService = phoneApplicationService;

    internal bool IsUserIdleEnabled
    {
      [SecuritySafeCritical] set
      {
        this.mIsUserIdleEnabled = value;
        Task rootTask = ApplicationHost.Current.RootTask;
        if (!value)
        {
          Task task1 = rootTask;
          task1.OnShow = task1.OnShow + new ITask.Show(this.OnShow);
          Task task2 = rootTask;
          task2.OnHide = task2.OnHide + new ITask.Hide(this.OnHide);
          if (this.preventLockTimer == null)
            this.preventLockTimer = new Timer(new TimerCallback(this.PreventLock));
          if (!NativeIdleBehavior.IdleBehaviorPolicy.CanCurrentApplicationDisableIdleTimer(rootTask))
            return;
          this.StartTimer();
        }
        else
        {
          Task task1 = rootTask;
          task1.OnShow = task1.OnShow - new ITask.Show(this.OnShow);
          Task task2 = rootTask;
          task2.OnHide = task2.OnHide - new ITask.Hide(this.OnHide);
          this.DisposeTimer();
        }
      }
    }

    internal void StartTimer()
    {
      lock (this.mLock)
      {
        if (this.mIsUserIdleEnabled || this.preventLockTimer == null)
          return;
        if (!NativeIdleBehavior.IdleBehaviorPolicy.IsShellInSmartCoverState())
          this.preventLockTimer.Change(0U, 20000U);
        else
          this.preventLockTimer.Change(0U, 4000U);
      }
    }

    private void DisposeTimer()
    {
      lock (this.mLock)
      {
        Timer preventLockTimer = this.preventLockTimer;
        if (preventLockTimer == null)
          return;
        this.preventLockTimer = (Timer) null;
        preventLockTimer.Dispose();
      }
    }

    private void StopTimer()
    {
      lock (this.mLock)
      {
        if (this.preventLockTimer == null)
          return;
        this.preventLockTimer.Change(-1, -1);
      }
    }

    private void OnHide(NavigationDirection direction) => this.StopTimer();

    private void OnShow(NavigationDirection direction) => this.StartTimer();

    [SecuritySafeCritical]
    [SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", Justification = "Ignoring result because an exception thrown from this timer thread cannot be caught by the app.")]
    private void PreventLock(object state)
    {
      if (!ApplicationHost.Current.RootTask.IsVisible)
        return;
      int num = (int) NativeIdleBehavior.NativeMethods.Shell_IdleTimerReset(NativeIdleBehavior.NativeMethods.IDLE_SESSION);
    }

    private static class IdleBehaviorPolicy
    {
      public static bool CanCurrentApplicationDisableIdleTimer(Task task)
      {
        bool flag = false;
        if (task.IsVisible)
          flag = !NativeIdleBehavior.NativeMethods.Shell_IsLocked() || NativeIdleBehavior.IdleBehaviorPolicy.IsShellInStateWhereIdleTimerCanBeDisabled();
        return flag;
      }

      private static bool IsShellInStateWhereIdleTimerCanBeDisabled()
      {
        bool flag = false;
        switch (NativeIdleBehavior.NativeMethods.Shell_GetCurrentMode())
        {
          case NativeIdleBehavior.ShellModeType.Camera:
          case NativeIdleBehavior.ShellModeType.SmartCover:
            flag = true;
            break;
        }
        return flag;
      }

      public static bool IsShellInSmartCoverState() => NativeIdleBehavior.ShellModeType.SmartCover == NativeIdleBehavior.NativeMethods.Shell_GetCurrentMode();
    }

    [SecurityCritical]
    private static class NativeMethods
    {
      public static uint IDLE_SESSION = 8;

      [DllImport("ShellChromeAPI.dll", SetLastError = true)]
      public static extern uint Shell_IdleTimerReset(uint dwFlags);

      [DllImport("ShellChromeAPI.dll", SetLastError = true)]
      [return: MarshalAs(UnmanagedType.Bool)]
      public static extern bool Shell_IsLocked();

      [DllImport("ShellChromeAPI.dll")]
      public static extern NativeIdleBehavior.ShellModeType Shell_GetCurrentMode();
    }

    private enum ShellModeType
    {
      Normal = 0,
      Kid = 1,
      Camera = 2,
      Wallet = 3,
      Speech = 4,
      LockApp = 5,
      AboveLock = 6,
      LockRestricted = 7,
      LastValid = 8,
      SmartCover = 8,
      ForceEnumSize = 2147483647, // 0x7FFFFFFF
    }
  }
}
