// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactAnnotationStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContactAnnotationStore : IContactAnnotationStore, IContactAnnotationStore2
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<string>> FindContactIdsByEmailAsync(
      string emailAddress);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<string>> FindContactIdsByPhoneNumberAsync(
      string phoneNumber);

    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ContactAnnotation>> FindAnnotationsForContactAsync(
      Contact contact);

    [MethodImpl]
    public extern IAsyncAction DisableAnnotationAsync(ContactAnnotation annotation);

    [RemoteAsync]
    [Overload("CreateAnnotationListAsync")]
    [MethodImpl]
    public extern IAsyncOperation<ContactAnnotationList> CreateAnnotationListAsync();

    [RemoteAsync]
    [Overload("CreateAnnotationListInAccountAsync")]
    [MethodImpl]
    public extern IAsyncOperation<ContactAnnotationList> CreateAnnotationListAsync(
      string userDataAccountId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ContactAnnotationList> GetAnnotationListAsync(
      string annotationListId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ContactAnnotationList>> FindAnnotationListsAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ContactAnnotation>> FindAnnotationsForContactListAsync(
      string contactListId);
  }
}
