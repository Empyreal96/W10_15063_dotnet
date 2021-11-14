// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.PM_STARTTILE_TYPE
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;

namespace Microsoft.Phone.Shell
{
  [Flags]
  internal enum PM_STARTTILE_TYPE
  {
    PM_STARTTILE_TYPE_PRIMARY = 1,
    PM_STARTTILE_TYPE_SECONDARY = 2,
    PM_STARTTILE_TYPE_APPLIST = PM_STARTTILE_TYPE_SECONDARY | PM_STARTTILE_TYPE_PRIMARY, // 0x00000003
    PM_STARTTILE_TYPE_APPLISTPRIMARY = 4,
    PM_STARTTILE_TYPE_INVALID = PM_STARTTILE_TYPE_APPLISTPRIMARY | PM_STARTTILE_TYPE_PRIMARY, // 0x00000005
  }
}
