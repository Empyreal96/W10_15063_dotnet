// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.DataProvider.IUserDataTaskListCompleteTaskRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks.DataProvider
{
  [ExclusiveTo(typeof (UserDataTaskListCompleteTaskRequest))]
  [Guid(4133360803, 6722, 18906, 133, 82, 40, 115, 229, 44, 85, 235)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IUserDataTaskListCompleteTaskRequest
  {
    string TaskListId { get; }

    string TaskId { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync(string completedTaskId);

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
