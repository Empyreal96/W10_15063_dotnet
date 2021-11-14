// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.DataProvider.IUserDataTaskListCreateOrUpdateTaskRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks.DataProvider
{
  [Guid(557020972, 21954, 17152, 130, 121, 4, 50, 110, 7, 204, 228)]
  [ExclusiveTo(typeof (UserDataTaskListCreateOrUpdateTaskRequest))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IUserDataTaskListCreateOrUpdateTaskRequest
  {
    string TaskListId { get; }

    UserDataTask Task { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync(UserDataTask createdOrUpdatedUserDataTask);

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
