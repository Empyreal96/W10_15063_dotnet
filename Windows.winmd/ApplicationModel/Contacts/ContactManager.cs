// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.System;
using Windows.UI.Popups;

namespace Windows.ApplicationModel.Contacts
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IContactManagerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IContactManagerStatics4), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IContactManagerStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IContactManagerStatics5), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IContactManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class ContactManager
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> IsShowFullContactCardSupportedAsync();

    public static extern bool IncludeMiddleNameInSystemDisplayAndSort { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public static extern ContactManagerForUser GetForUser(User user);

    [RemoteAsync]
    [Overload("ConvertContactToVCardAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<RandomAccessStreamReference> ConvertContactToVCardAsync(
      Contact contact);

    [RemoteAsync]
    [Overload("ConvertContactToVCardAsyncWithMaxBytes")]
    [MethodImpl]
    public static extern IAsyncOperation<RandomAccessStreamReference> ConvertContactToVCardAsync(
      Contact contact,
      uint maxBytes);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Contact> ConvertVCardToContactAsync(
      IRandomAccessStreamReference vCard);

    [RemoteAsync]
    [Overload("RequestStoreAsyncWithAccessType")]
    [MethodImpl]
    public static extern IAsyncOperation<ContactStore> RequestStoreAsync(
      ContactStoreAccessType accessType);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ContactAnnotationStore> RequestAnnotationStoreAsync(
      ContactAnnotationStoreAccessType accessType);

    [MethodImpl]
    public static extern bool IsShowContactCardSupported();

    [Overload("ShowContactCardWithOptions")]
    [MethodImpl]
    public static extern void ShowContactCard(
      Contact contact,
      Rect selection,
      Placement preferredPlacement,
      ContactCardOptions contactCardOptions);

    [MethodImpl]
    public static extern bool IsShowDelayLoadedContactCardSupported();

    [Overload("ShowDelayLoadedContactCardWithOptions")]
    [MethodImpl]
    public static extern ContactCardDelayedDataLoader ShowDelayLoadedContactCard(
      Contact contact,
      Rect selection,
      Placement preferredPlacement,
      ContactCardOptions contactCardOptions);

    [MethodImpl]
    public static extern void ShowFullContactCard(
      Contact contact,
      FullContactCardOptions fullContactCardOptions);

    public static extern ContactNameOrder SystemDisplayNameOrder { [MethodImpl] get; [MethodImpl] set; }

    public static extern ContactNameOrder SystemSortOrder { [MethodImpl] get; [MethodImpl] set; }

    [RemoteAsync]
    [Overload("RequestStoreAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<ContactStore> RequestStoreAsync();

    [Overload("ShowContactCard")]
    [MethodImpl]
    public static extern void ShowContactCard(Contact contact, Rect selection);

    [Overload("ShowContactCardWithPlacement")]
    [MethodImpl]
    public static extern void ShowContactCard(
      Contact contact,
      Rect selection,
      Placement preferredPlacement);

    [Overload("ShowDelayLoadedContactCard")]
    [MethodImpl]
    public static extern ContactCardDelayedDataLoader ShowDelayLoadedContactCard(
      Contact contact,
      Rect selection,
      Placement preferredPlacement);
  }
}
