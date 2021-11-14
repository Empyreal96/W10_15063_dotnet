// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Sync.AccountSyncContentFreshness
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Sync
{
  [Version(100859904)]
  public enum AccountSyncContentFreshness
  {
    KeepAll = -1, // 0xFFFFFFFF
    KeepPast1Days = 1,
    KeepPast3Days = 3,
    DefaultFreshness = 7,
    KeepPast7Days = 7,
    KeepPast14Days = 14, // 0x0000000E
    KeepPast30Days = 30, // 0x0000001E
    KeepPast90Days = 90, // 0x0000005A
  }
}
