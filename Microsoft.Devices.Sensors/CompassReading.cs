// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.Sensors.CompassReading
// Assembly: Microsoft.Devices.Sensors, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 469A1B9D-3538-4EC4-AFBC-0CC2C106C824
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI782A~1.DLL

using Microsoft.Xna.Framework;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Devices.Sensors
{
  [SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes", Justification = "No need to do that")]
  public struct CompassReading : ISensorReading
  {
    public DateTimeOffset Timestamp { get; internal set; }

    public double HeadingAccuracy { get; internal set; }

    public double TrueHeading { get; internal set; }

    public Vector3 MagnetometerReading { get; internal set; }

    public double MagneticHeading { get; internal set; }

    internal CompassReading(CompassNativeSample nativeSample)
      : this()
    {
      this.Timestamp = nativeSample.header.TimeStamp;
      this.HeadingAccuracy = (double) nativeSample.fErrorMargin;
      this.TrueHeading = (double) nativeSample.fTrueBearing;
      this.MagnetometerReading = new Vector3(nativeSample.vecMagCalibrated.X, nativeSample.vecMagCalibrated.Y, nativeSample.vecMagCalibrated.Z);
      this.MagneticHeading = (double) nativeSample.fMagBearing;
    }
  }
}
