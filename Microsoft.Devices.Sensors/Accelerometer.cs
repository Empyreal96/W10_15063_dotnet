// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.Sensors.Accelerometer
// Assembly: Microsoft.Devices.Sensors, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 469A1B9D-3538-4EC4-AFBC-0CC2C106C824
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI782A~1.DLL

using Microsoft.Phone;
using Microsoft.Phone.Interop;
using Microsoft.Phone.Shell;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Devices.Sensors
{
  public sealed class Accelerometer : SensorBase<AccelerometerReading>
  {
    internal AccelerometerNativeSample mCurrentValue;
    internal IAccelerometer mAccSensor;
    private static readonly uint DefaultIntervalMs = 20;
    private bool mShouldSimulate7Accelerometer;
    private static bool isSupportedInitialized = false;
    private static bool isSupported = false;

    public Accelerometer()
    {
      this.mShouldSimulate7Accelerometer = QuirksMode.ShouldSimulate7Accelerometer();
      this.State = SensorState.Ready;
      this.mTimeBetweenUpdatesInMs = Accelerometer.DefaultIntervalMs;
      AccelerometerInterop sensorInterop = Accelerometer.GetSensorInterop();
      this.mSensor = (ISensorBase) sensorInterop;
      this.mAccSensor = (IAccelerometer) sensorInterop;
      this.mPausableSensor = (IPausableResource) sensorInterop;
      this.mCurrentValue = new AccelerometerNativeSample();
      Exception sensorError = (Exception) null;
      bool flag = SensorBase<AccelerometerReading>.CheckSensorPresence(this.mSensor, ref sensorError);
      if (sensorError == null)
      {
        Accelerometer.IsSupported = flag;
        if (!flag)
          this.State = SensorState.NotSupported;
      }
      else
        this.State = !(sensorError is OutOfMemoryException) ? SensorState.NoPermissions : SensorState.Disabled;
      this.CurrentValueChanged += new EventHandler<SensorReadingEventArgs<AccelerometerReading>>(this.OnReadingChanged);
      this.RegisterForPauseResumeEvents();
      if (!this.mShouldSimulate7Accelerometer || PhoneApplicationService.Current == null)
        return;
      PhoneApplicationService.Current.Closing += new EventHandler<ClosingEventArgs>(this.App_Closing);
    }

    private void App_Closing(object sender, ClosingEventArgs args)
    {
    }

    public new void Dispose() => base.Dispose();

    internal override void Dispose(bool disposing)
    {
      lock (this.m_Lock)
      {
        this.mAccSensor = (IAccelerometer) null;
        base.Dispose(disposing);
      }
    }

    internal override void CheckIsSupported()
    {
      if (!Accelerometer.IsSupported)
        throw new InvalidOperationException("Sensor is not present on this platform.");
    }

    internal override void CheckIsPermitted()
    {
      if (this.State == SensorState.NoPermissions)
        throw new UnauthorizedAccessException(SensorBase<AccelerometerReading>.m_UnauthorizedAccessMessage);
    }

    public static bool IsSupported
    {
      get
      {
        if (!Accelerometer.isSupportedInitialized)
          Accelerometer.IsSupported = SensorBase<AccelerometerReading>.CheckSensorPresence((ISensorBase) Accelerometer.GetSensorInterop());
        return Accelerometer.isSupported;
      }
      internal set
      {
        Accelerometer.isSupportedInitialized = true;
        Accelerometer.isSupported = value;
      }
    }

    private static void Initialize()
    {
      int num = (int) ComBridge.RegisterComDllInternal("SensorsNative.dll", new Guid("D0BBEDE7-21B2-44d2-A75E-57843C02E6E1"));
    }

    private static AccelerometerInterop GetSensorInterop()
    {
      Accelerometer.Initialize();
      return new AccelerometerInterop();
    }

    internal override ISensorReading ConvertSample(IntPtr sample) => (ISensorReading) new AccelerometerReading((AccelerometerNativeSample) Marshal.PtrToStructure(sample, typeof (AccelerometerNativeSample)));

    internal override ISensorReading GetCurrentValue()
    {
      lock (this.m_Lock)
      {
        if (this.mAccSensor != null)
          this.mAccSensor.GetCurrentSample(ref this.mCurrentValue);
        return (ISensorReading) new AccelerometerReading(this.mCurrentValue);
      }
    }

    [Obsolete("use CurrentValueChanged")]
    public event EventHandler<AccelerometerReadingEventArgs> ReadingChanged;

    private void DoSensorStateChecks()
    {
      if (this.State == SensorState.NoPermissions)
        throw new UnauthorizedAccessException(SensorBase<AccelerometerReading>.m_UnauthorizedAccessMessage);
      if (this.m_disposed)
        throw new ObjectDisposedException(nameof (Accelerometer), "Accelerometer object has already been disposed.");
      if (this.State == SensorState.NotSupported)
        throw new AccelerometerFailedException("Accelerometer sensor is not available on this platform.");
      if (this.State == SensorState.Disabled)
        throw new AccelerometerFailedException("Creating new instance failed due to insufficient memory.", -2147024882);
    }

    public new void Start()
    {
      if (this.mShouldSimulate7Accelerometer)
        this.DoSensorStateChecks();
      try
      {
        base.Start();
      }
      catch (SensorFailedException ex)
      {
        throw new AccelerometerFailedException("Accelerometer failed to start. Platform threw exception.", ex.ErrorId);
      }
    }

    public new void Stop()
    {
      if (this.mShouldSimulate7Accelerometer)
        this.DoSensorStateChecks();
      try
      {
        base.Stop();
      }
      catch (SensorFailedException ex)
      {
        throw new AccelerometerFailedException("Accelerometer failed to stop. Platform threw exception.", ex.ErrorId);
      }
    }

    internal void OnReadingChanged(
      object sender,
      SensorReadingEventArgs<AccelerometerReading> sample)
    {
      EventHandler<AccelerometerReadingEventArgs> readingChanged = this.ReadingChanged;
      if (readingChanged == null)
        return;
      readingChanged((object) this, new AccelerometerReadingEventArgs(sample.SensorReading));
    }

    public SensorState State { get; private set; }
  }
}
