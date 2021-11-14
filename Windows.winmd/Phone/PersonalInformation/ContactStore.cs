// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.ContactStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Static(typeof (IContactStoreStatics), 65536, "Windows.Phone.PhoneContract")]
  public sealed class ContactStore : IContactStore, IContactStore2
  {
    [MethodImpl]
    public extern IAsyncOperation<StoredContact> FindContactByRemoteIdAsync(
      string id);

    [MethodImpl]
    public extern IAsyncOperation<StoredContact> FindContactByIdAsync(
      string id);

    [MethodImpl]
    public extern IAsyncAction DeleteContactAsync(string id);

    [Overload("CreateContactQueryDefault")]
    [MethodImpl]
    public extern ContactQueryResult CreateContactQuery();

    [Overload("CreateContactQueryWithOptions")]
    [MethodImpl]
    public extern ContactQueryResult CreateContactQuery(
      ContactQueryOptions options);

    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    public extern ulong RevisionNumber { [MethodImpl] get; }

    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ContactChangeRecord>> GetChangesAsync(
      ulong baseRevisionNumber);

    [MethodImpl]
    [return: HasVariant]
    public extern IAsyncOperation<IMap<string, object>> LoadExtendedPropertiesAsync();

    [MethodImpl]
    public extern IAsyncAction SaveExtendedPropertiesAsync([HasVariant] IMapView<string, object> data);

    [MethodImpl]
    public extern IAsyncOperation<StoredContact> CreateMeContactAsync(
      string id);

    [Overload("CreateOrOpenAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<ContactStore> CreateOrOpenAsync();

    [Overload("CreateOrOpenWithOptionsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<ContactStore> CreateOrOpenAsync(
      ContactStoreSystemAccessMode access,
      ContactStoreApplicationAccessMode sharing);
  }
}
