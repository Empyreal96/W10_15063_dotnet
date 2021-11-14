// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.DispatcherTimerWin32
// Assembly: Microsoft.Xna.Framework.Game, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 6EBDB755-3EEE-4715-BDC3-9A6D92805A5E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB65~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Xna.Framework
{
  internal class DispatcherTimerWin32
  {
    private MsgTimerCallback _timerProcCallback;
    private const uint TimerId = 233397373;
    private TimeSpan _interval;

    public event EventHandler Tick;

    [SecuritySafeCritical]
    public DispatcherTimerWin32()
    {
      IntPtr zero = IntPtr.Zero;
      this._timerProcCallback = new MsgTimerCallback(this.TimerElapsed);
      Helpers.ThrowExceptionFromResult(MobileNativeMethods.CreateTimer(this._timerProcCallback, ref zero));
      this.Handle = zero;
    }

    ~DispatcherTimerWin32() => this.Release();

    [SecuritySafeCritical]
    [AllowReversePInvokeCalls]
    private void TimerElapsed(IntPtr pvUserData) => this.Tick((object) this, EventArgs.Empty);

    [SecuritySafeCritical]
    public void Release()
    {
      if (!(this.Handle != IntPtr.Zero))
        return;
      int num = (int) MobileNativeMethods.ReleaseTimer(this.Handle);
      this.Handle = IntPtr.Zero;
    }

    public bool IsValid => this.Handle != IntPtr.Zero;

    public IntPtr Handle { get; private set; }

    public TimeSpan Interval
    {
      get => this._interval;
      set
      {
        this._interval = value;
        if (!this.IsEnabled)
          return;
        this.Stop();
        this.Start();
      }
    }

    private long IntervalIn100nsUnits
    {
      get
      {
        double a = Math.Max(0.0, this._interval.TotalMilliseconds);
        if (this.PreferOvershoot)
          a = Math.Ceiling(a);
        return (long) a * 1000L;
      }
    }

    public bool IsEnabled { get; private set; }

    public bool PreferOvershoot { get; set; }

    [SecuritySafeCritical]
    public void Start()
    {
      if (!this.IsValid)
        throw new InvalidOperationException();
      if (this.IsEnabled)
        this.Stop();
      long initialTimeoutIn100nsUnits = this.IntervalIn100nsUnits;
      long repeatedTimeoutIn100nsUnits = 0;
      if (initialTimeoutIn100nsUnits <= 0L)
        initialTimeoutIn100nsUnits = 100L;
      Helpers.ThrowExceptionFromResult(MobileNativeMethods.SetRelativeTimer(this.Handle, initialTimeoutIn100nsUnits, repeatedTimeoutIn100nsUnits));
      this.IsEnabled = true;
    }

    [SecuritySafeCritical]
    public void Stop()
    {
      if (!this.IsValid || !this.IsEnabled)
        return;
      this.IsEnabled = false;
      Helpers.ThrowExceptionFromResult(MobileNativeMethods.CancelTimer(this.Handle));
    }
  }
}
