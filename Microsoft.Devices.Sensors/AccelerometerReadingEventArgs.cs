// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.Sensors.AccelerometerReadingEventArgs
// Assembly: Microsoft.Devices.Sensors, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 469A1B9D-3538-4EC4-AFBC-0CC2C106C824
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI782A~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Devices.Sensors
{
  public class AccelerometerReadingEventArgs : EventArgs
  {
    private double x;
    private double y;
    private double z;

    internal AccelerometerReadingEventArgs(AccelerometerNativeSample accNativeSample)
    {
      this.x = (double) accNativeSample.x;
      this.y = (double) accNativeSample.y;
      this.z = (double) accNativeSample.z;
      this.Timestamp = accNativeSample.header.TimeStamp;
    }

    internal AccelerometerReadingEventArgs(AccelerometerReading accReading)
    {
      this.Timestamp = accReading.Timestamp;
      this.x = (double) accReading.Acceleration.X;
      this.y = (double) accReading.Acceleration.Y;
      this.z = (double) accReading.Acceleration.Z;
    }

    [SuppressMessage("Microsoft.Naming", "CA1704")]
    public double X => this.x;

    [SuppressMessage("Microsoft.Naming", "CA1704")]
    public double Y => this.y;

    [SuppressMessage("Microsoft.Naming", "CA1704")]
    public double Z => this.z;

    public DateTimeOffset Timestamp { get; private set; }
  }
}
