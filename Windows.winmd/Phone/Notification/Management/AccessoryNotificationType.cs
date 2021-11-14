// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.AccessoryNotificationType
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [Flags]
  [ContractVersion(typeof (PhoneContract), 65536)]
  public enum AccessoryNotificationType : uint
  {
    None = 0,
    Phone = 1,
    Email = 2,
    Reminder = 4,
    Alarm = 8,
    Toast = 16, // 0x00000010
    AppUninstalled = 32, // 0x00000020
    Dnd = 64, // 0x00000040
    DrivingMode = 128, // 0x00000080
    BatterySaver = 256, // 0x00000100
    Media = 512, // 0x00000200
    CortanaTile = 1024, // 0x00000400
    ToastCleared = 2048, // 0x00000800
    CalendarChanged = 4096, // 0x00001000
    VolumeChanged = 8192, // 0x00002000
    EmailReadStatusChanged = 16384, // 0x00004000
  }
}
