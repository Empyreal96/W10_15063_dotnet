// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactAnnotationList
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContactAnnotationList : IContactAnnotationList
  {
    public extern string Id { [MethodImpl] get; }

    public extern string ProviderPackageFamilyName { [MethodImpl] get; }

    public extern string UserDataAccountId { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    [MethodImpl]
    public extern IAsyncOperation<bool> TrySaveAnnotationAsync(
      ContactAnnotation annotation);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ContactAnnotation> GetAnnotationAsync(
      string annotationId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ContactAnnotation>> FindAnnotationsByRemoteIdAsync(
      string remoteId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ContactAnnotation>> FindAnnotationsAsync();

    [MethodImpl]
    public extern IAsyncAction DeleteAnnotationAsync(ContactAnnotation annotation);
  }
}
