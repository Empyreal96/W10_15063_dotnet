// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.Sensors.Gyroscope
// Assembly: Microsoft.Devices.Sensors, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 469A1B9D-3538-4EC4-AFBC-0CC2C106C824
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI782A~1.DLL

using Microsoft.Phone.Interop;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Devices.Sensors
{
  public sealed class Gyroscope : SensorBase<GyroscopeReading>
  {
    internal GyroscopeNativeSample mCurrentValue;
    internal IGyroscope mGyrSensor;
    private static readonly uint DefaultIntervalMs = 20;
    private static bool isSupportedInitialized = false;
    private static bool isSupported = false;

    public Gyroscope()
    {
      this.mTimeBetweenUpdatesInMs = Gyroscope.DefaultIntervalMs;
      GyroscopeInterop sensorInterop = Gyroscope.GetSensorInterop();
      this.mSensor = (ISensorBase) sensorInterop;
      this.mGyrSensor = (IGyroscope) sensorInterop;
      this.mPausableSensor = (IPausableResource) sensorInterop;
      this.mCurrentValue = new GyroscopeNativeSample();
      if (!Gyroscope.isSupportedInitialized)
      {
        Exception sensorError = (Exception) null;
        bool flag = SensorBase<GyroscopeReading>.CheckSensorPresence(this.mSensor, ref sensorError);
        if (sensorError == null)
        {
          Gyroscope.IsSupported = flag;
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
        this.mGyrSensor = (IGyroscope) null;
        base.Dispose(disposing);
      }
    }

    internal override void CheckIsSupported()
    {
      if (!Gyroscope.IsSupported)
        throw new InvalidOperationException("Sensor is not present on this platform.");
    }

    internal override void CheckIsPermitted()
    {
      if (this.State == SensorState.NoPermissions)
        throw new UnauthorizedAccessException(SensorBase<GyroscopeReading>.m_UnauthorizedAccessMessage);
    }

    public static bool IsSupported
    {
      get
      {
        if (!Gyroscope.isSupportedInitialized)
          Gyroscope.IsSupported = SensorBase<GyroscopeReading>.CheckSensorPresence((ISensorBase) Gyroscope.GetSensorInterop());
        return Gyroscope.isSupported;
      }
      internal set
      {
        Gyroscope.isSupportedInitialized = true;
        Gyroscope.isSupported = value;
      }
    }

    private static void Initialize()
    {
      int num = (int) ComBridge.RegisterComDllInternal("SensorsNative.dll", new Guid("E9ECA890-75E4-40f9-AA30-FFE396450F0E"));
    }

    private static GyroscopeInterop GetSensorInterop()
    {
      Gyroscope.Initialize();
      return new GyroscopeInterop();
    }

    internal override ISensorReading ConvertSample(IntPtr sample) => (ISensorReading) new GyroscopeReading((GyroscopeNativeSample) Marshal.PtrToStructure(sample, typeof (GyroscopeNativeSample)));

    internal override ISensorReading GetCurrentValue()
    {
      lock (this.m_Lock)
      {
        if (this.mGyrSensor != null)
          this.mGyrSensor.GetCurrentSample(ref this.mCurrentValue);
        return (ISensorReading) new GyroscopeReading(this.mCurrentValue);
      }
    }

    private SensorState State { get; set; }
  }
}
