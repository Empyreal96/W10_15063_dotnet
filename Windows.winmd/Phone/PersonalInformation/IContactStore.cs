// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.IContactStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation
{
  [Guid(2999807983, 11261, 20397, 133, 82, 78, 105, 128, 151, 232, 235)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [ExclusiveTo(typeof (ContactStore))]
  internal interface IContactStore
  {
    IAsyncOperation<StoredContact> FindContactByRemoteIdAsync(string id);

    IAsyncOperation<StoredContact> FindContactByIdAsync(string id);

    IAsyncAction DeleteContactAsync(string id);

    [Overload("CreateContactQueryDefault")]
    ContactQueryResult CreateContactQuery();

    [Overload("CreateContactQueryWithOptions")]
    ContactQueryResult CreateContactQuery(ContactQueryOptions options);

    IAsyncAction DeleteAsync();

    ulong RevisionNumber { get; }

    IAsyncOperation<IVectorView<ContactChangeRecord>> GetChangesAsync(
      ulong baseRevisionNumber);

    [return: HasVariant]
    IAsyncOperation<IMap<string, object>> LoadExtendedPropertiesAsync();

    IAsyncAction SaveExtendedPropertiesAsync([HasVariant] IMapView<string, object> data);
  }
}
