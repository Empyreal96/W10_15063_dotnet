// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.Sensors.IAccelerometer
// Assembly: Microsoft.Devices.Sensors, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 469A1B9D-3538-4EC4-AFBC-0CC2C106C824
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI782A~1.DLL

using System.Runtime.InteropServices;

namespace Microsoft.Devices.Sensors
{
  [Guid("78A2FAFD-5380-4f4d-800B-E13839DF5C0F")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  internal interface IAccelerometer
  {
    void CheckHardwarePresence();

    void Start();

    void Stop();

    void UpdateTimeBetweenSamples(uint desiredTimeBetweenSamples, ref uint actualTimeBetweenSamples);

    void GetIsDataValid([MarshalAs(UnmanagedType.Bool)] ref bool isDataValid);

    void SetCallback(ISensorBaseCallback sensorCallback);

    void GetCurrentSample(ref AccelerometerNativeSample sample);
  }
}
