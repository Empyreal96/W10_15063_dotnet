// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.PM_LIVETILE_SCHEDULE
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

namespace Microsoft.Phone.Shell
{
  internal struct PM_LIVETILE_SCHEDULE
  {
    public PM_LIVETILE_RECURRENCE_TYPE recurrenceType;
    public PM_LIVETILE_INTERVAL_KIND intervalKind;
    public uint runForever;
    public uint maximumRunCount;
    public uint runCount;
    public uint reserved;
    public uint startTime_LowDateTime;
    public uint startTime_HighDateTime;
    public uint nextTime_LowDateTime;
    public uint nextTime_HighDateTime;
    public uint fUserNoneIdle;
  }
}
