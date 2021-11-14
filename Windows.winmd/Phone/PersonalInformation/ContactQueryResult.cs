// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.ContactQueryResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContactQueryResult : IContactQueryResult
  {
    [MethodImpl]
    public extern IAsyncOperation<uint> GetContactCountAsync();

    [Overload("GetContactsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StoredContact>> GetContactsAsync();

    [Overload("GetContactsAsyncInRange")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StoredContact>> GetContactsAsync(
      uint startIndex,
      uint maxNumberOfItems);

    [MethodImpl]
    public extern ContactQueryOptions GetCurrentQueryOptions();
  }
}
