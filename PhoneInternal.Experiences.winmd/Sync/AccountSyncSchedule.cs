// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Sync.AccountSyncSchedule
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Sync
{
  [Version(100859904)]
  public enum AccountSyncSchedule
  {
    BasedOnMyUsage = -1879048193, // 0x8FFFFFFF
    AsItemsArrive = -1, // 0xFFFFFFFF
    Manual = 0,
    Periodic15Min = 15, // 0x0000000F
    Periodic30Min = 30, // 0x0000001E
    Periodic60Min = 60, // 0x0000003C
    PeriodicTwoHour = 120, // 0x00000078
    PeriodicDaily = 1440, // 0x000005A0
  }
}
