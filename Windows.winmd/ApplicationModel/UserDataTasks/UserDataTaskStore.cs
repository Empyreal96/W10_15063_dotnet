// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.UserDataTaskStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class UserDataTaskStore : IUserDataTaskStore
  {
    [RemoteAsync]
    [Overload("CreateListAsync")]
    [MethodImpl]
    public extern IAsyncOperation<UserDataTaskList> CreateListAsync(
      string name);

    [Overload("CreateListInAccountAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UserDataTaskList> CreateListAsync(
      string name,
      string userDataAccountId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<UserDataTaskList>> FindListsAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UserDataTaskList> GetListAsync(
      string taskListId);
  }
}
