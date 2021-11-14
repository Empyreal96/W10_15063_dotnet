// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.Sensors.SensorBase`1
// Assembly: Microsoft.Devices.Sensors, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 469A1B9D-3538-4EC4-AFBC-0CC2C106C824
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI782A~1.DLL

using Microsoft.Phone;
using Microsoft.Phone.Shell;
using MS.Internal.Interop;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Devices.Sensors
{
  public abstract class SensorBase<TSensorReading> : IDisposable where TSensorReading : ISensorReading
  {
    internal static string m_UnauthorizedAccessMessage = "Access to Sensors requires ID_CAP_SENSORS to be defined in the manifest.";
    internal bool m_disposed;
    private bool m_isDataValid;
    internal object m_Lock = new object();
    internal object m_Lock_mSensor = new object();
    internal ISensorBase mSensor;
    internal SensorCallback mSensorCallback;
    internal IPausableResource mPausableSensor;
    internal uint mTimeBetweenUpdatesInMs;
    private EventHandler<ClosingEventArgs> mWeakClosingHandler;
    private EventHandler<NativeSensorEventArgs> mWeakReadingHandler;
    private bool mShouldThrowIfDisposedOnSensorStop;
    private EventHandler<NotificationCallbackEventArgs> mWeakPauseHandler;
    private EventHandler mWeakResumeHandler;
    private EventHandler<SensorReadingEventArgs<TSensorReading>> _readingChangedEventHandler;

    public TSensorReading CurrentValue
    {
      get
      {
        this.CheckIsSupported();
        this.CheckIsPermitted();
        return (TSensorReading) this.GetCurrentValue();
      }
    }

    public TimeSpan TimeBetweenUpdates
    {
      get => TimeSpan.FromMilliseconds((double) this.mTimeBetweenUpdatesInMs);
      set
      {
        this.CheckIsSupported();
        this.CheckIsPermitted();
        uint betweenUpdatesInMs = this.mTimeBetweenUpdatesInMs;
        lock (this.m_Lock_mSensor)
        {
          if (this.mSensor != null)
          {
            double totalMilliseconds = value.TotalMilliseconds;
            this.mSensor.UpdateTimeBetweenSamples(totalMilliseconds >= 0.0 ? (totalMilliseconds < (double) uint.MaxValue ? (uint) totalMilliseconds : uint.MaxValue) : 0U, ref betweenUpdatesInMs);
          }
        }
        this.mTimeBetweenUpdatesInMs = betweenUpdatesInMs;
      }
    }

    public bool IsDataValid
    {
      get
      {
        lock (this.m_Lock_mSensor)
        {
          if (!this.m_isDataValid)
          {
            if (this.mSensor != null)
              this.mSensor.GetIsDataValid(ref this.m_isDataValid);
          }
        }
        return this.m_isDataValid;
      }
    }

    internal void RegisterForPauseResumeEvents()
    {
      if (this.mSensorCallback == null)
        return;
      XPauseType pauseType;
      NotificationService.Register((INotificationCallback) this.mSensorCallback, ref pauseType);
      this.PauseResumeSensor(pauseType);
    }

    internal SensorBase()
    {
      this.mShouldThrowIfDisposedOnSensorStop = QuirksMode.ShouldThrowIfDisposedOnSensorStop();
      this.mSensorCallback = new SensorCallback();
      WeakReference thisWeak = new WeakReference((object) this);
      if (PhoneApplicationService.Current != null)
      {
        this.mWeakClosingHandler = (EventHandler<ClosingEventArgs>) ((sender, args) =>
        {
          if (!(thisWeak.Target is SensorBase<TSensorReading> target1))
            return;
          target1.App_Closing(sender, args);
        });
        PhoneApplicationService.Current.Closing += this.mWeakClosingHandler;
      }
      this.mWeakReadingHandler = (EventHandler<NativeSensorEventArgs>) ((sender, args) =>
      {
        if (!(thisWeak.Target is SensorBase<TSensorReading> target1))
          return;
        target1.OnNewReading(sender, args);
      });
      this.mSensorCallback.NewReading += this.mWeakReadingHandler;
      this.mWeakPauseHandler = (EventHandler<NotificationCallbackEventArgs>) ((sender, args) =>
      {
        if (!(thisWeak.Target is SensorBase<TSensorReading> target1))
          return;
        target1.PauseResumeSensor(args.PauseType);
      });
      this.mSensorCallback.Pause += this.mWeakPauseHandler;
      this.mWeakResumeHandler = (EventHandler) ((sender, args) =>
      {
        if (!(thisWeak.Target is SensorBase<TSensorReading> target1))
          return;
        target1.PauseResumeSensor((XPauseType) 0);
      });
      this.mSensorCallback.Resume += this.mWeakResumeHandler;
    }

    [SecuritySafeCritical]
    ~SensorBase() => this.Dispose(false);

    private void App_Closing(object sender, ClosingEventArgs args) => this.Dispose();

    internal virtual void Dispose(bool disposing)
    {
      if (this.m_disposed)
        return;
      try
      {
        lock (this.m_Lock)
        {
          NotificationService.Unregister((INotificationCallback) this.mSensorCallback);
          if (this.mSensor != null)
          {
            this.mSensor.Stop();
            this.mSensor.SetCallback((ISensorBaseCallback) null);
          }
          this.m_isDataValid = false;
          lock (this.m_Lock_mSensor)
            this.mSensor = (ISensorBase) null;
          this.mPausableSensor = (IPausableResource) null;
          this.mSensorCallback = (SensorCallback) null;
          this.m_disposed = true;
        }
      }
      catch (Exception ex)
      {
      }
    }

    [SecuritySafeCritical]
    public void Dispose()
    {
      try
      {
        this.Dispose(true);
        GC.SuppressFinalize((object) this);
      }
      catch (Exception ex)
      {
      }
    }

    public event EventHandler<SensorReadingEventArgs<TSensorReading>> CurrentValueChanged
    {
      add
      {
        lock (this.m_Lock)
        {
          if (this._readingChangedEventHandler == null && this.mSensor != null)
            this.mSensor.SetCallback((ISensorBaseCallback) this.mSensorCallback);
          this._readingChangedEventHandler += value;
        }
      }
      remove
      {
        lock (this.m_Lock)
        {
          this._readingChangedEventHandler -= value;
          if (this._readingChangedEventHandler != null || this.mSensor == null)
            return;
          this.mSensor.SetCallback((ISensorBaseCallback) null);
        }
      }
    }

    public virtual void Start()
    {
      if (this.m_disposed)
        throw new ObjectDisposedException("Sensor", "Sensor object has already been disposed.");
      this.CheckIsSupported();
      this.CheckIsPermitted();
      lock (this.m_Lock)
      {
        if (this.mSensor == null)
          return;
        try
        {
          this.mSensor.Start();
        }
        catch (COMException ex)
        {
          if (ex.ErrorCode == HResults.E_MAXSENSORS)
            throw new SensorFailedException("Sensor failed to start. Too many sensors of this type currently running");
          throw new SensorFailedException("Sensor failed to start. Platform threw exception. Check ErrorId.", ex.ErrorCode);
        }
      }
    }

    [SuppressMessage("Microsoft.Naming", "CA1716", Justification = "This API has already shipped, any changes will constitute a breaking change.")]
    public virtual void Stop()
    {
      if (this.mShouldThrowIfDisposedOnSensorStop && this.m_disposed)
        throw new ObjectDisposedException("Sensor", "Sensor object has already been disposed.");
      lock (this.m_Lock)
      {
        if (this.mSensor == null)
          return;
        try
        {
          this.mSensor.Stop();
        }
        catch (COMException ex)
        {
          throw new SensorFailedException("Sensor failed to stop. Platform threw exception. Check ErrorId.", ex.ErrorCode);
        }
        this.m_isDataValid = false;
      }
    }

    private void FireOnReadingChanged(SensorReadingEventArgs<TSensorReading> sample)
    {
      EventHandler<SensorReadingEventArgs<TSensorReading>> changedEventHandler = this._readingChangedEventHandler;
      if (changedEventHandler == null)
        return;
      changedEventHandler((object) this, sample);
    }

    internal void OnNewReading(object sender, NativeSensorEventArgs sample)
    {
      TSensorReading sensorReading = (TSensorReading) this.ConvertSample(sample.Reading);
      this.FireOnReadingChanged(new SensorReadingEventArgs<TSensorReading>()
      {
        SensorReading = sensorReading
      });
    }

    internal static bool CheckSensorPresence(ISensorBase sensor)
    {
      Exception sensorError = (Exception) null;
      int num = SensorBase<TSensorReading>.CheckSensorPresence(sensor, ref sensorError) ? 1 : 0;
      if (sensorError == null)
        return num != 0;
      throw sensorError;
    }

    internal static bool CheckSensorPresence(ISensorBase sensor, ref Exception sensorError)
    {
      bool flag = false;
      try
      {
        sensor.CheckHardwarePresence();
        flag = true;
      }
      catch (FileNotFoundException ex)
      {
        flag = false;
      }
      catch (UnauthorizedAccessException ex)
      {
        sensorError = (Exception) new UnauthorizedAccessException(SensorBase<TSensorReading>.m_UnauthorizedAccessMessage);
      }
      catch (COMException ex)
      {
        switch (ex.ErrorCode)
        {
          case -2147024882:
            sensorError = (Exception) new OutOfMemoryException();
            break;
          case -2147024841:
          case -2147024773:
            flag = false;
            break;
          default:
            flag = false;
            break;
        }
      }
      return flag;
    }

    private void PauseResumeSensor(XPauseType pauseType)
    {
      if (pauseType == 4)
        this.PauseSensor();
      else
        this.ResumeSensor();
    }

    internal void PauseSensor()
    {
      lock (this.m_Lock)
      {
        if (this.mPausableSensor == null)
          return;
        this.mPausableSensor.Pause();
        this.m_isDataValid = false;
      }
    }

    internal void ResumeSensor()
    {
      lock (this.m_Lock)
      {
        if (this.mPausableSensor == null)
          return;
        this.mPausableSensor.Resume();
      }
    }

    internal abstract void CheckIsSupported();

    internal abstract void CheckIsPermitted();

    internal abstract ISensorReading ConvertSample(IntPtr sample);

    internal abstract ISensorReading GetCurrentValue();
  }
}
