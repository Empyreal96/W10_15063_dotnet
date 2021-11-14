// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.IUserDataTaskListLimitedWriteOperations
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2057463794, 24696, 16771, 145, 158, 79, 41, 241, 156, 250, 233)]
  [ExclusiveTo(typeof (UserDataTaskListLimitedWriteOperations))]
  internal interface IUserDataTaskListLimitedWriteOperations
  {
    [RemoteAsync]
    IAsyncOperation<string> TryCompleteTaskAsync(string userDataTaskId);

    [RemoteAsync]
    IAsyncOperation<bool> TryCreateOrUpdateTaskAsync(UserDataTask userDataTask);

    [RemoteAsync]
    IAsyncOperation<bool> TryDeleteTaskAsync(string userDataTaskId);

    [RemoteAsync]
    IAsyncOperation<bool> TrySkipOccurrenceAsync(string userDataTaskId);
  }
}
