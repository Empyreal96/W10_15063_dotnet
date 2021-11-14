// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactChangeReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactChangeReader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(561191418, 11532, 17120, 169, 218, 62, 205, 86, 167, 138, 71)]
  internal interface IContactChangeReader
  {
    void AcceptChanges();

    void AcceptChangesThrough(ContactChange lastChangeToAccept);

    [RemoteAsync]
    IAsyncOperation<IVectorView<ContactChange>> ReadBatchAsync();
  }
}
