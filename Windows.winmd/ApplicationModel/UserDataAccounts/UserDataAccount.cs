// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.UserDataAccount
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Appointments;
using Windows.ApplicationModel.Contacts;
using Windows.ApplicationModel.Email;
using Windows.ApplicationModel.UserDataTasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.UserDataAccounts
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class UserDataAccount : 
    IUserDataAccount,
    IUserDataAccount2,
    IUserDataAccount3,
    IUserDataAccount4
  {
    public extern string Id { [MethodImpl] get; }

    public extern string UserDisplayName { [MethodImpl] get; [MethodImpl] set; }

    public extern UserDataAccountOtherAppReadAccess OtherAppReadAccess { [MethodImpl] get; [MethodImpl] set; }

    public extern IRandomAccessStreamReference Icon { [MethodImpl] get; [MethodImpl] set; }

    public extern string DeviceAccountTypeId { [MethodImpl] get; }

    public extern string PackageFamilyName { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppointmentCalendar>> FindAppointmentCalendarsAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<EmailMailbox>> FindEmailMailboxesAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ContactList>> FindContactListsAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ContactAnnotationList>> FindContactAnnotationListsAsync();

    public extern string EnterpriseId { [MethodImpl] get; }

    public extern bool IsProtectedUnderLock { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> ExplictReadAccessPackageFamilyNames { [MethodImpl] get; }

    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanShowCreateContactGroup { [MethodImpl] get; [MethodImpl] set; }

    public extern IPropertySet ProviderProperties { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<UserDataTaskList>> FindUserDataTaskListsAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ContactGroup>> FindContactGroupsAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> TryShowCreateContactGroupAsync();
  }
}
