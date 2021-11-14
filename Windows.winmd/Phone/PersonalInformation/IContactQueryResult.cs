// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.IContactQueryResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation
{
  [ExclusiveTo(typeof (ContactQueryResult))]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(3225270050, 60635, 18176, 133, 126, 62, 120, 100, 38, 176, 75)]
  internal interface IContactQueryResult
  {
    IAsyncOperation<uint> GetContactCountAsync();

    [Overload("GetContactsAsync")]
    IAsyncOperation<IVectorView<StoredContact>> GetContactsAsync();

    [Overload("GetContactsAsyncInRange")]
    IAsyncOperation<IVectorView<StoredContact>> GetContactsAsync(
      uint startIndex,
      uint maxNumberOfItems);

    ContactQueryOptions GetCurrentQueryOptions();
  }
}
