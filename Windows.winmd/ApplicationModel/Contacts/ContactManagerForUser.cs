// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactManagerForUser
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.System;

namespace Windows.ApplicationModel.Contacts
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class ContactManagerForUser : IContactManagerForUser, IContactManagerForUser2
  {
    [Overload("ConvertContactToVCardAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<RandomAccessStreamReference> ConvertContactToVCardAsync(
      Contact contact);

    [RemoteAsync]
    [Overload("ConvertContactToVCardAsyncWithMaxBytes")]
    [MethodImpl]
    public extern IAsyncOperation<RandomAccessStreamReference> ConvertContactToVCardAsync(
      Contact contact,
      uint maxBytes);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Contact> ConvertVCardToContactAsync(
      IRandomAccessStreamReference vCard);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ContactStore> RequestStoreAsync(
      ContactStoreAccessType accessType);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ContactAnnotationStore> RequestAnnotationStoreAsync(
      ContactAnnotationStoreAccessType accessType);

    public extern ContactNameOrder SystemDisplayNameOrder { [MethodImpl] get; [MethodImpl] set; }

    public extern ContactNameOrder SystemSortOrder { [MethodImpl] get; [MethodImpl] set; }

    public extern User User { [MethodImpl] get; }

    [MethodImpl]
    public extern void ShowFullContactCard(
      Contact contact,
      FullContactCardOptions fullContactCardOptions);
  }
}
