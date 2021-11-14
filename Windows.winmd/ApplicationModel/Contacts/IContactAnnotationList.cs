// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactAnnotationList
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactAnnotationList))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2460255914, 23688, 17849, 170, 208, 70, 24, 136, 230, 141, 138)]
  internal interface IContactAnnotationList
  {
    string Id { get; }

    string ProviderPackageFamilyName { get; }

    string UserDataAccountId { get; }

    [RemoteAsync]
    IAsyncAction DeleteAsync();

    IAsyncOperation<bool> TrySaveAnnotationAsync(ContactAnnotation annotation);

    [RemoteAsync]
    IAsyncOperation<ContactAnnotation> GetAnnotationAsync(
      string annotationId);

    [RemoteAsync]
    IAsyncOperation<IVectorView<ContactAnnotation>> FindAnnotationsByRemoteIdAsync(
      string remoteId);

    [RemoteAsync]
    IAsyncOperation<IVectorView<ContactAnnotation>> FindAnnotationsAsync();

    IAsyncAction DeleteAnnotationAsync(ContactAnnotation annotation);
  }
}
