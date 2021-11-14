// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContactReader))]
  [Guid(3549946926, 5256, 17138, 191, 100, 37, 63, 72, 132, 191, 237)]
  internal interface IContactReader
  {
    [RemoteAsync]
    IAsyncOperation<ContactBatch> ReadBatchAsync();

    IVectorView<ContactMatchReason> GetMatchingPropertiesWithMatchReason(
      Contact contact);
  }
}
