// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.IUserDataTaskStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  [Guid(4033518768, 61915, 17850, 138, 98, 8, 96, 4, 192, 33, 61)]
  [ExclusiveTo(typeof (UserDataTaskStore))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IUserDataTaskStore
  {
    [Overload("CreateListAsync")]
    [RemoteAsync]
    IAsyncOperation<UserDataTaskList> CreateListAsync(string name);

    [RemoteAsync]
    [Overload("CreateListInAccountAsync")]
    IAsyncOperation<UserDataTaskList> CreateListAsync(
      string name,
      string userDataAccountId);

    [RemoteAsync]
    IAsyncOperation<IVectorView<UserDataTaskList>> FindListsAsync();

    [RemoteAsync]
    IAsyncOperation<UserDataTaskList> GetListAsync(string taskListId);
  }
}
