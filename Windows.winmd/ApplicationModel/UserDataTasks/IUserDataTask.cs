// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.IUserDataTask
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (UserDataTask))]
  [Guid(2087028177, 57556, 20377, 174, 226, 188, 45, 93, 218, 223, 76)]
  internal interface IUserDataTask
  {
    string Id { get; }

    string ListId { get; }

    string RemoteId { get; set; }

    IReference<DateTime> CompletedDate { get; set; }

    string Details { get; set; }

    UserDataTaskDetailsKind DetailsKind { get; set; }

    IReference<DateTime> DueDate { get; set; }

    UserDataTaskKind Kind { get; }

    UserDataTaskPriority Priority { get; set; }

    UserDataTaskRecurrenceProperties RecurrenceProperties { get; set; }

    UserDataTaskRegenerationProperties RegenerationProperties { get; set; }

    IReference<DateTime> Reminder { get; set; }

    UserDataTaskSensitivity Sensitivity { get; set; }

    string Subject { get; set; }

    IReference<DateTime> StartDate { get; set; }
  }
}
