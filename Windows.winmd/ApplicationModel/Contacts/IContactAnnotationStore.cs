// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactAnnotationStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(598537386, 31351, 17789, 130, 3, 152, 127, 75, 49, 175, 9)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContactAnnotationStore))]
  internal interface IContactAnnotationStore
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<string>> FindContactIdsByEmailAsync(
      string emailAddress);

    [RemoteAsync]
    IAsyncOperation<IVectorView<string>> FindContactIdsByPhoneNumberAsync(
      string phoneNumber);

    IAsyncOperation<IVectorView<ContactAnnotation>> FindAnnotationsForContactAsync(
      Contact contact);

    IAsyncAction DisableAnnotationAsync(ContactAnnotation annotation);

    [RemoteAsync]
    [Overload("CreateAnnotationListAsync")]
    IAsyncOperation<ContactAnnotationList> CreateAnnotationListAsync();

    [Overload("CreateAnnotationListInAccountAsync")]
    [RemoteAsync]
    IAsyncOperation<ContactAnnotationList> CreateAnnotationListAsync(
      string userDataAccountId);

    [RemoteAsync]
    IAsyncOperation<ContactAnnotationList> GetAnnotationListAsync(
      string annotationListId);

    [RemoteAsync]
    IAsyncOperation<IVectorView<ContactAnnotationList>> FindAnnotationListsAsync();
  }
}
