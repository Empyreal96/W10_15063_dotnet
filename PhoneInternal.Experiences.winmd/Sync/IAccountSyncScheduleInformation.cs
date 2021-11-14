// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Sync.IAccountSyncScheduleInformation
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Sync
{
  [Version(100859904)]
  [ExclusiveTo(typeof (AccountSyncScheduleInformation))]
  [Guid(1361263690, 54920, 17592, 128, 8, 39, 124, 214, 120, 4, 16)]
  internal interface IAccountSyncScheduleInformation
  {
    AccountSyncSchedule AccountSyncSchedule { get; }

    bool AdaptiveToSaveDataUsage { get; }
  }
}
