// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.Sensors.TimeUtil
// Assembly: Microsoft.Devices.Sensors, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 469A1B9D-3538-4EC4-AFBC-0CC2C106C824
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI782A~1.DLL

using System;

namespace Microsoft.Devices.Sensors
{
  internal static class TimeUtil
  {
    private static TimeSpan s_timeOffset;
    private static bool s_initialized = false;
    private static object s_lock = new object();

    private static void Initialize()
    {
      lock (TimeUtil.s_lock)
      {
        if (TimeUtil.s_initialized)
          return;
        TimeUtil.s_timeOffset = DateTimeOffset.Now.Offset;
        TimeUtil.s_initialized = true;
      }
    }

    public static DateTimeOffset ConvertGTCToSLDateTimeOffset(long timeIn100NS)
    {
      if (!TimeUtil.s_initialized)
        TimeUtil.Initialize();
      try
      {
        return new DateTimeOffset(DateTime.FromFileTime(timeIn100NS), TimeUtil.s_timeOffset);
      }
      catch (Exception ex)
      {
        return DateTimeOffset.Now;
      }
    }
  }
}
