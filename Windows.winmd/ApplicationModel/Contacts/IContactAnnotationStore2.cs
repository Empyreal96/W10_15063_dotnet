// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactAnnotationStore2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactAnnotationStore))]
  [Guid(2128487421, 25063, 18791, 142, 197, 189, 242, 128, 162, 64, 99)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IContactAnnotationStore2
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<ContactAnnotation>> FindAnnotationsForContactListAsync(
      string contactListId);
  }
}
