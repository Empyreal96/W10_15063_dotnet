// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.IUserDataTaskRecurrenceProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  [ExclusiveTo(typeof (UserDataTaskRecurrenceProperties))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1944027312, 10182, 16590, 177, 73, 156, 212, 20, 133, 166, 158)]
  internal interface IUserDataTaskRecurrenceProperties
  {
    UserDataTaskRecurrenceUnit Unit { get; set; }

    IReference<int> Occurrences { get; set; }

    IReference<DateTime> Until { get; set; }

    int Interval { get; set; }

    IReference<UserDataTaskDaysOfWeek> DaysOfWeek { get; set; }

    IReference<UserDataTaskWeekOfMonth> WeekOfMonth { get; set; }

    IReference<int> Month { get; set; }

    IReference<int> Day { get; set; }
  }
}
