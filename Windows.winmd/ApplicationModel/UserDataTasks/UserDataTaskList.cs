// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.UserDataTaskList
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class UserDataTaskList : IUserDataTaskList
  {
    public extern string Id { [MethodImpl] get; }

    public extern string UserDataAccountId { [MethodImpl] get; }

    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    public extern string SourceDisplayName { [MethodImpl] get; }

    public extern UserDataTaskListOtherAppReadAccess OtherAppReadAccess { [MethodImpl] get; [MethodImpl] set; }

    public extern UserDataTaskListOtherAppWriteAccess OtherAppWriteAccess { [MethodImpl] get; [MethodImpl] set; }

    public extern UserDataTaskListLimitedWriteOperations LimitedWriteOperations { [MethodImpl] get; }

    public extern UserDataTaskListSyncManager SyncManager { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RegisterSyncManagerAsync();

    [Overload("GetTaskReader")]
    [MethodImpl]
    public extern UserDataTaskReader GetTaskReader();

    [Overload("GetTaskReaderWithOptions")]
    [MethodImpl]
    public extern UserDataTaskReader GetTaskReader(
      UserDataTaskQueryOptions options);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UserDataTask> GetTaskAsync(
      string userDataTask);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveTaskAsync(UserDataTask userDataTask);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteTaskAsync(string userDataTaskId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveAsync();
  }
}
