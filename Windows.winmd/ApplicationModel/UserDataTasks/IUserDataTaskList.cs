// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.IUserDataTaskList
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (UserDataTaskList))]
  [Guid(1229008441, 31773, 19953, 190, 211, 49, 75, 124, 191, 94, 78)]
  internal interface IUserDataTaskList
  {
    string Id { get; }

    string UserDataAccountId { get; }

    string DisplayName { get; set; }

    string SourceDisplayName { get; }

    UserDataTaskListOtherAppReadAccess OtherAppReadAccess { get; set; }

    UserDataTaskListOtherAppWriteAccess OtherAppWriteAccess { get; set; }

    UserDataTaskListLimitedWriteOperations LimitedWriteOperations { get; }

    UserDataTaskListSyncManager SyncManager { get; }

    [RemoteAsync]
    IAsyncAction RegisterSyncManagerAsync();

    [Overload("GetTaskReader")]
    UserDataTaskReader GetTaskReader();

    [Overload("GetTaskReaderWithOptions")]
    UserDataTaskReader GetTaskReader(UserDataTaskQueryOptions options);

    [RemoteAsync]
    IAsyncOperation<UserDataTask> GetTaskAsync(string userDataTask);

    [RemoteAsync]
    IAsyncAction SaveTaskAsync(UserDataTask userDataTask);

    [RemoteAsync]
    IAsyncAction DeleteTaskAsync(string userDataTaskId);

    [RemoteAsync]
    IAsyncAction DeleteAsync();

    [RemoteAsync]
    IAsyncAction SaveAsync();
  }
}
