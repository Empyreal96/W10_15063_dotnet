// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Sync.PartnershipType
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Sync
{
  [Version(100859904)]
  public enum PartnershipType
  {
    Invalid = 1,
    Unknown = 2,
    ActiveSyncExchange = 3,
    ActiveSyncGoogle = 4,
    ActiveSyncMicrosoft = 5,
    InternetMailPopImap = 6,
    InternetGoogle = 7,
    InternetIcloud = 8,
    VisualVoiceMail = 9,
    InternetYahoo = 10, // 0x0000000A
  }
}
