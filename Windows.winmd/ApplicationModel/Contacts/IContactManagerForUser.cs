// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactManagerForUser
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.System;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (ContactManagerForUser))]
  [Guid(3075193431, 4214, 19439, 174, 243, 84, 104, 109, 24, 56, 125)]
  internal interface IContactManagerForUser
  {
    [Overload("ConvertContactToVCardAsync")]
    [RemoteAsync]
    IAsyncOperation<RandomAccessStreamReference> ConvertContactToVCardAsync(
      Contact contact);

    [RemoteAsync]
    [Overload("ConvertContactToVCardAsyncWithMaxBytes")]
    IAsyncOperation<RandomAccessStreamReference> ConvertContactToVCardAsync(
      Contact contact,
      uint maxBytes);

    [RemoteAsync]
    IAsyncOperation<Contact> ConvertVCardToContactAsync(
      IRandomAccessStreamReference vCard);

    [RemoteAsync]
    IAsyncOperation<ContactStore> RequestStoreAsync(
      ContactStoreAccessType accessType);

    [RemoteAsync]
    IAsyncOperation<ContactAnnotationStore> RequestAnnotationStoreAsync(
      ContactAnnotationStoreAccessType accessType);

    ContactNameOrder SystemDisplayNameOrder { get; set; }

    ContactNameOrder SystemSortOrder { get; set; }

    User User { get; }
  }
}
