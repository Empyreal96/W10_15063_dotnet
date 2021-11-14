// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.PM_LIVETILE_INTERVAL_KIND
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;

namespace Microsoft.Phone.Shell
{
  [Flags]
  internal enum PM_LIVETILE_INTERVAL_KIND
  {
    PM_LIVETILE_INTERVAL_KIND_EVERY_HOUR = 0,
    PM_LIVETILE_INTERVAL_KIND_EVERY_DAY = 1,
    PM_LIVETILE_INTERVAL_KIND_EVERY_WEEK = 2,
    PM_LIVETILE_INTERVAL_KIND_EVERY_MONTH = PM_LIVETILE_INTERVAL_KIND_EVERY_WEEK | PM_LIVETILE_INTERVAL_KIND_EVERY_DAY, // 0x00000003
  }
}
