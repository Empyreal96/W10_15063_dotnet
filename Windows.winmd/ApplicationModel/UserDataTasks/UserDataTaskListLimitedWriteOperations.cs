// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.UserDataTaskListLimitedWriteOperations
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UserDataTaskListLimitedWriteOperations : 
    IUserDataTaskListLimitedWriteOperations
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> TryCompleteTaskAsync(string userDataTaskId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryCreateOrUpdateTaskAsync(
      UserDataTask userDataTask);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryDeleteTaskAsync(string userDataTaskId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySkipOccurrenceAsync(string userDataTaskId);
  }
}
