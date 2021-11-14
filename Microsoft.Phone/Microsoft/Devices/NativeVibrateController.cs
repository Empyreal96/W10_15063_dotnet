// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.NativeVibrateController
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Shell;
using System;
using System.Security;
using System.Threading;

namespace Microsoft.Devices
{
  [SecuritySafeCritical]
  internal class NativeVibrateController
  {
    private VibrationResourceManagerHandle vbm;
    private int mNextVibration = -1;
    private object mNextVibrationLock = new object();
    private EventWaitHandle[] mWaitHandles;
    private int mVibrationEventIndex;
    private int mThreadExitEventIndex = 1;

    public NativeVibrateController()
    {
      this.mWaitHandles = (EventWaitHandle[]) null;
      NativeMethods.BeginManagingVibration(out this.vbm);
      this.mWaitHandles = new EventWaitHandle[2];
      this.mWaitHandles[this.mVibrationEventIndex] = (EventWaitHandle) new AutoResetEvent(false);
      this.mWaitHandles[this.mThreadExitEventIndex] = (EventWaitHandle) new ManualResetEvent(false);
      if (PhoneApplicationService.Current != null)
        PhoneApplicationService.Current.Closing += new EventHandler<ClosingEventArgs>(this.App_Closing);
      new Thread(new ThreadStart(this.ProcessAllVibrations))
      {
        IsBackground = true
      }.Start();
    }

    public void Vibrate(TimeSpan duration)
    {
      int num = (int) Math.Round(duration.TotalMilliseconds);
      lock (this.mNextVibrationLock)
      {
        if (num > this.mNextVibration)
          this.mNextVibration = num;
      }
      this.mWaitHandles[this.mVibrationEventIndex].Set();
    }

    private void ProcessAllVibrations()
    {
      this.VibrationEndingTime = DateTime.Now;
      int num;
      do
      {
        int milliseconds = 0;
        lock (this.mNextVibrationLock)
        {
          milliseconds = this.mNextVibration;
          this.mNextVibration = 0;
        }
        TimeSpan timeout = this.ProcessCurrentVibration(milliseconds);
        DateTime now = DateTime.Now;
        num = WaitHandle.WaitAny((WaitHandle[]) this.mWaitHandles, timeout);
        if (num == 258)
        {
          NativeVibrateController.IsVibrating = false;
          num = WaitHandle.WaitAny((WaitHandle[]) this.mWaitHandles);
        }
      }
      while (num != this.mThreadExitEventIndex);
      NativeVibrateController.IsVibrating = false;
    }

    private TimeSpan ProcessCurrentVibration(int milliseconds)
    {
      DateTime now = DateTime.Now;
      if (milliseconds > 0)
      {
        NativeVibrateController.IsVibrating = true;
        DateTime dateTime = now.AddMilliseconds((double) milliseconds);
        if (dateTime.CompareTo(this.VibrationEndingTime) > 0)
          this.VibrationEndingTime = dateTime;
      }
      else if (milliseconds == -1)
      {
        NativeVibrateController.IsVibrating = false;
        this.VibrationEndingTime = now;
      }
      TimeSpan timeSpan = this.VibrationEndingTime - now;
      if (timeSpan.Ticks < 0L)
        timeSpan = TimeSpan.Zero;
      return timeSpan;
    }

    public void Stop()
    {
      lock (this.mNextVibrationLock)
        this.mNextVibration = -1;
      this.mWaitHandles[this.mVibrationEventIndex].Set();
    }

    private void App_Closing(object sender, ClosingEventArgs args) => this.mWaitHandles[this.mThreadExitEventIndex].Set();

    private static bool IsVibrating
    {
      set
      {
        if (value)
          NativeMethods.Vibrate();
        else
          NativeMethods.Stop();
      }
    }

    private DateTime VibrationEndingTime { get; set; }
  }
}
