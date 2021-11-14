// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.IUserDataAccount4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Contacts;
using Windows.ApplicationModel.UserDataTasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.UserDataAccounts
{
  [ExclusiveTo(typeof (UserDataAccount))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3291566608, 60133, 20234, 168, 178, 28, 202, 17, 94, 0, 143)]
  internal interface IUserDataAccount4
  {
    bool CanShowCreateContactGroup { get; set; }

    IPropertySet ProviderProperties { get; }

    [RemoteAsync]
    IAsyncOperation<IVectorView<UserDataTaskList>> FindUserDataTaskListsAsync();

    [RemoteAsync]
    IAsyncOperation<IVectorView<ContactGroup>> FindContactGroupsAsync();

    [RemoteAsync]
    IAsyncOperation<string> TryShowCreateContactGroupAsync();

    bool IsProtectedUnderLock { set; }

    IRandomAccessStreamReference Icon { set; }
  }
}
