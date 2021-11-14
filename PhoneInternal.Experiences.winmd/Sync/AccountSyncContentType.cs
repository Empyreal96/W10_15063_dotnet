// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Sync.AccountSyncContentType
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Sync
{
  [Version(100859904)]
  public enum AccountSyncContentType
  {
    None = 0,
    Contacts = 1,
    Email = 2,
    Calendar = 4,
    Tasks = 8,
    Feeds = 96, // 0x00000060
    Photos = 384, // 0x00000180
  }
}
