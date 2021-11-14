// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.Sensors.SensorCallback
// Assembly: Microsoft.Devices.Sensors, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 469A1B9D-3538-4EC4-AFBC-0CC2C106C824
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI782A~1.DLL

using Microsoft.Phone;
using MS.Internal.Interop;
using System;
using System.Windows;

namespace Microsoft.Devices.Sensors
{
  internal class SensorCallback : ISensorBaseCallback, ICalibrateCallback, INotificationCallback
  {
    private NativeSensorEventArgs nativeSensorEventArgs = new NativeSensorEventArgs();
    private NativeCalibrateEventArgs nativeCalibrateEventArgs = new NativeCalibrateEventArgs();
    private NotificationCallbackEventArgs pauseEventArgs = new NotificationCallbackEventArgs();
    private EventArgs resumeEventArgs = new EventArgs();

    public event EventHandler<NativeSensorEventArgs> NewReading;

    public event EventHandler<NativeCalibrateEventArgs> Calibrate;

    public event EventHandler<NotificationCallbackEventArgs> Pause;

    public event EventHandler Resume;

    public void OnNewReading(IntPtr pNewReading)
    {
      try
      {
        this.nativeSensorEventArgs.Reading = pNewReading;
        EventHandler<NativeSensorEventArgs> newReading = this.NewReading;
        if (newReading == null)
          return;
        newReading((object) this, this.nativeSensorEventArgs);
      }
      catch (Exception ex)
      {
        Application.OnPlatformAssemblyUnhandledException(ex, true);
      }
    }

    public void OnCalibrate()
    {
      try
      {
        EventHandler<NativeCalibrateEventArgs> calibrate = this.Calibrate;
        if (calibrate == null)
          return;
        calibrate((object) this, this.nativeCalibrateEventArgs);
      }
      catch (Exception ex)
      {
        Application.OnPlatformAssemblyUnhandledException(ex, true);
      }
    }

    void INotificationCallback.Pausing(XPauseType pauseType)
    {
      if (QuirksMode.ShouldSimulate7Accelerometer())
        return;
      this.pauseEventArgs.PauseType = pauseType;
      EventHandler<NotificationCallbackEventArgs> pause = this.Pause;
      if (pause == null)
        return;
      pause((object) this, this.pauseEventArgs);
    }

    void INotificationCallback.Paused(XPauseType pauseType)
    {
      if (!QuirksMode.ShouldSimulate7Accelerometer())
        return;
      this.pauseEventArgs.PauseType = pauseType;
      EventHandler<NotificationCallbackEventArgs> pause = this.Pause;
      if (pause == null)
        return;
      pause((object) this, this.pauseEventArgs);
    }

    void INotificationCallback.Resuming()
    {
      if (!QuirksMode.ShouldSimulate7Accelerometer())
        return;
      EventHandler resume = this.Resume;
      if (resume == null)
        return;
      resume((object) this, this.resumeEventArgs);
    }

    void INotificationCallback.Resumed()
    {
      if (QuirksMode.ShouldSimulate7Accelerometer())
        return;
      EventHandler resume = this.Resume;
      if (resume == null)
        return;
      resume((object) this, this.resumeEventArgs);
    }
  }
}
