// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.Sensors.Compass
// Assembly: Microsoft.Devices.Sensors, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 469A1B9D-3538-4EC4-AFBC-0CC2C106C824
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI782A~1.DLL

using Microsoft.Phone.Interop;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Devices.Sensors
{
  public sealed class Compass : SensorBase<CompassReading>
  {
    internal CompassNativeSample mCurrentValue;
    internal ICompass mCpsSensor;
    internal ICalibratingSensor mCalibratingSensor;
    private static readonly uint DefaultIntervalMs = 25;
    private static bool isSupportedInitialized = false;
    private static bool isSupported = false;

    public event EventHandler<CalibrationEventArgs> Calibrate;

    public Compass()
    {
      this.mSensorCallback.Calibrate += new EventHandler<NativeCalibrateEventArgs>(this.OnCalibrate);
      this.mTimeBetweenUpdatesInMs = Compass.DefaultIntervalMs;
      CompassInterop sensorInterop = Compass.GetSensorInterop();
      this.mSensor = (ISensorBase) sensorInterop;
      this.mCpsSensor = (ICompass) sensorInterop;
      this.mCalibratingSensor = (ICalibratingSensor) sensorInterop;
      this.mPausableSensor = (IPausableResource) sensorInterop;
      this.mCalibratingSensor.SetCallback((ICalibrateCallback) this.mSensorCallback);
      this.mCurrentValue = new CompassNativeSample();
      if (!Compass.isSupportedInitialized)
      {
        Exception sensorError = (Exception) null;
        bool flag = SensorBase<CompassReading>.CheckSensorPresence(this.mSensor, ref sensorError);
        if (sensorError == null)
        {
          Compass.IsSupported = flag;
          if (!flag)
            this.State = SensorState.NotSupported;
        }
        else
          this.State = !(sensorError is OutOfMemoryException) ? SensorState.NoPermissions : SensorState.Disabled;
      }
      this.RegisterForPauseResumeEvents();
    }

    internal override void Dispose(bool disposing)
    {
      lock (this.m_Lock)
      {
        this.mCpsSensor = (ICompass) null;
        this.mCalibratingSensor = (ICalibratingSensor) null;
        base.Dispose(disposing);
      }
    }

    internal override void CheckIsSupported()
    {
      if (!Compass.IsSupported)
        throw new InvalidOperationException("Sensor is not present on this platform.");
    }

    internal override void CheckIsPermitted()
    {
      if (this.State == SensorState.NoPermissions)
        throw new UnauthorizedAccessException(SensorBase<CompassReading>.m_UnauthorizedAccessMessage);
    }

    public static bool IsSupported
    {
      get
      {
        if (!Compass.isSupportedInitialized)
          Compass.IsSupported = SensorBase<CompassReading>.CheckSensorPresence((ISensorBase) Compass.GetSensorInterop());
        return Compass.isSupported;
      }
      internal set
      {
        Compass.isSupportedInitialized = true;
        Compass.isSupported = value;
      }
    }

    private static void Initialize()
    {
      int num = (int) ComBridge.RegisterComDllInternal("SensorsNative.dll", new Guid("F405BD2D-2E62-41ad-B689-721F37D7AC98"));
    }

    private static CompassInterop GetSensorInterop()
    {
      Compass.Initialize();
      return new CompassInterop();
    }

    internal override ISensorReading ConvertSample(IntPtr sample) => (ISensorReading) new CompassReading((CompassNativeSample) Marshal.PtrToStructure(sample, typeof (CompassNativeSample)));

    internal override ISensorReading GetCurrentValue()
    {
      lock (this.m_Lock)
      {
        if (this.mCpsSensor != null)
          this.mCpsSensor.GetCurrentSample(ref this.mCurrentValue);
        return (ISensorReading) new CompassReading(this.mCurrentValue);
      }
    }

    internal void OnCalibrate(object sender, NativeCalibrateEventArgs calibrate)
    {
      CalibrationEventArgs e = new CalibrationEventArgs();
      EventHandler<CalibrationEventArgs> calibrate1 = this.Calibrate;
      if (calibrate1 == null)
        return;
      calibrate1((object) this, e);
    }

    private SensorState State { get; set; }
  }
}
