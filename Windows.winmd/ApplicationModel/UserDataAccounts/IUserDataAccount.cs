// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.IUserDataAccount
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Appointments;
using Windows.ApplicationModel.Contacts;
using Windows.ApplicationModel.Email;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.UserDataAccounts
{
  [Guid(3116643966, 45896, 18704, 190, 148, 74, 212, 187, 166, 222, 167)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UserDataAccount))]
  internal interface IUserDataAccount
  {
    string Id { get; }

    string UserDisplayName { get; set; }

    UserDataAccountOtherAppReadAccess OtherAppReadAccess { get; set; }

    IRandomAccessStreamReference Icon { get; }

    string DeviceAccountTypeId { get; }

    string PackageFamilyName { get; }

    [RemoteAsync]
    IAsyncAction SaveAsync();

    [RemoteAsync]
    IAsyncAction DeleteAsync();

    [RemoteAsync]
    IAsyncOperation<IVectorView<AppointmentCalendar>> FindAppointmentCalendarsAsync();

    [RemoteAsync]
    IAsyncOperation<IVectorView<EmailMailbox>> FindEmailMailboxesAsync();

    [RemoteAsync]
    IAsyncOperation<IVectorView<ContactList>> FindContactListsAsync();

    [RemoteAsync]
    IAsyncOperation<IVectorView<ContactAnnotationList>> FindContactAnnotationListsAsync();
  }
}
