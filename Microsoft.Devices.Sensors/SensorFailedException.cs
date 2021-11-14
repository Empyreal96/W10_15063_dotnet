// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.Sensors.SensorFailedException
// Assembly: Microsoft.Devices.Sensors, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 469A1B9D-3538-4EC4-AFBC-0CC2C106C824
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI782A~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Devices.Sensors
{
  [SuppressMessage("Microsoft.Design", "CA1032")]
  public class SensorFailedException : Exception
  {
    private int m_errorId;

    [SuppressMessage("Microsoft.Design", "CA1032")]
    internal SensorFailedException()
    {
    }

    [SuppressMessage("Microsoft.Design", "CA1032")]
    internal SensorFailedException(string message)
      : base(message)
    {
    }

    internal SensorFailedException(string message, int ErrorId)
      : base(message)
    {
      this.m_errorId = ErrorId;
    }

    public int ErrorId => this.m_errorId;
  }
}
