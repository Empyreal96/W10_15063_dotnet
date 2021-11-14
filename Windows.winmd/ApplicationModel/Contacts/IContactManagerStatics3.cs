// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactManagerStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.UI.Popups;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3301719362, 30086, 18730, 147, 11, 123, 193, 56, 252, 33, 57)]
  internal interface IContactManagerStatics3 : IContactManagerStatics2, IContactManagerStatics
  {
    [RemoteAsync]
    [Overload("ConvertContactToVCardAsync")]
    IAsyncOperation<RandomAccessStreamReference> ConvertContactToVCardAsync(
      Contact contact);

    [Overload("ConvertContactToVCardAsyncWithMaxBytes")]
    [RemoteAsync]
    IAsyncOperation<RandomAccessStreamReference> ConvertContactToVCardAsync(
      Contact contact,
      uint maxBytes);

    [RemoteAsync]
    IAsyncOperation<Contact> ConvertVCardToContactAsync(
      IRandomAccessStreamReference vCard);

    [Overload("RequestStoreAsyncWithAccessType")]
    [RemoteAsync]
    IAsyncOperation<ContactStore> RequestStoreAsync(
      ContactStoreAccessType accessType);

    [RemoteAsync]
    IAsyncOperation<ContactAnnotationStore> RequestAnnotationStoreAsync(
      ContactAnnotationStoreAccessType accessType);

    bool IsShowContactCardSupported();

    [Overload("ShowContactCardWithOptions")]
    void ShowContactCard(
      Contact contact,
      Rect selection,
      Placement preferredPlacement,
      ContactCardOptions contactCardOptions);

    bool IsShowDelayLoadedContactCardSupported();

    [Overload("ShowDelayLoadedContactCardWithOptions")]
    ContactCardDelayedDataLoader ShowDelayLoadedContactCard(
      Contact contact,
      Rect selection,
      Placement preferredPlacement,
      ContactCardOptions contactCardOptions);

    void ShowFullContactCard(Contact contact, FullContactCardOptions fullContactCardOptions);

    ContactNameOrder SystemDisplayNameOrder { get; set; }

    ContactNameOrder SystemSortOrder { get; set; }
  }
}
