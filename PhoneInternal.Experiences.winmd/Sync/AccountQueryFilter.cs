// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Sync.AccountQueryFilter
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Sync
{
  [Version(100859904)]
  [Flags]
  public enum AccountQueryFilter : uint
  {
    None = 0,
    Email = 1,
    Contacts = 2,
    Calendar = 4,
    Tasks = 8,
    Photos = 16, // 0x00000010
    Feeds = 32, // 0x00000020
  }
}
