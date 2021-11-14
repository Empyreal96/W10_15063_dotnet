// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.Sensors.Motion
// Assembly: Microsoft.Devices.Sensors, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 469A1B9D-3538-4EC4-AFBC-0CC2C106C824
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI782A~1.DLL

using Microsoft.Phone.Interop;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Devices.Sensors
{
  public sealed class Motion : SensorBase<MotionReading>
  {
    internal MotionNativeSample mCurrentValue;
    internal IMotion mMtnSensor;
    internal ICalibratingSensor mCalibratingSensor;
    private static readonly uint DefaultIntervalMs = 17;
    private static bool isSupportedInitialized = false;
    private static bool isSupported = false;

    public event EventHandler<CalibrationEventArgs> Calibrate;

    public Motion()
    {
      this.mSensorCallback.Calibrate += new EventHandler<NativeCalibrateEventArgs>(this.OnCalibrate);
      this.mTimeBetweenUpdatesInMs = Motion.DefaultIntervalMs;
      MotionInterop sensorInterop = Motion.GetSensorInterop();
      this.mSensor = (ISensorBase) sensorInterop;
      this.mMtnSensor = (IMotion) sensorInterop;
      this.mCalibratingSensor = (ICalibratingSensor) sensorInterop;
      this.mPausableSensor = (IPausableResource) sensorInterop;
      this.mCalibratingSensor.SetCallback((ICalibrateCallback) this.mSensorCallback);
      this.mCurrentValue = new MotionNativeSample();
      if (!Motion.isSupportedInitialized)
      {
        Exception sensorError = (Exception) null;
        bool flag = SensorBase<MotionReading>.CheckSensorPresence(this.mSensor, ref sensorError);
        if (sensorError == null)
        {
          Motion.IsSupported = flag;
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
        this.mMtnSensor = (IMotion) null;
        this.mCalibratingSensor = (ICalibratingSensor) null;
        base.Dispose(disposing);
      }
    }

    internal override void CheckIsSupported()
    {
      if (!Motion.IsSupported)
        throw new InvalidOperationException("Sensor is not present on this platform.");
    }

    internal override void CheckIsPermitted()
    {
      if (this.State == SensorState.NoPermissions)
        throw new UnauthorizedAccessException(SensorBase<MotionReading>.m_UnauthorizedAccessMessage);
    }

    public static bool IsSupported
    {
      get
      {
        if (!Motion.isSupportedInitialized)
          Motion.IsSupported = SensorBase<MotionReading>.CheckSensorPresence((ISensorBase) Motion.GetSensorInterop());
        return Motion.isSupported;
      }
      internal set
      {
        Motion.isSupportedInitialized = true;
        Motion.isSupported = value;
      }
    }

    private static void Initialize()
    {
      int num = (int) ComBridge.RegisterComDllInternal("SensorsNative.dll", new Guid("D22966B6-E993-457d-9275-A282BD63856A"));
    }

    private static MotionInterop GetSensorInterop()
    {
      Motion.Initialize();
      return new MotionInterop();
    }

    internal override ISensorReading ConvertSample(IntPtr sample) => (ISensorReading) new MotionReading((MotionNativeSample) Marshal.PtrToStructure(sample, typeof (MotionNativeSample)));

    internal override ISensorReading GetCurrentValue()
    {
      lock (this.m_Lock)
      {
        if (this.mMtnSensor != null)
          this.mMtnSensor.GetCurrentSample(ref this.mCurrentValue);
        return (ISensorReading) new MotionReading(this.mCurrentValue);
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
