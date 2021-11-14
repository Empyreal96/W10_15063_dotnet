// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.AggregateContactManager
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
  public sealed class AggregateContactManager : IAggregateContactManager, IAggregateContactManager2
  {
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<Contact>> FindRawContactsAsync(
      Contact contact);

    [MethodImpl]
    public extern IAsyncOperation<Contact> TryLinkContactsAsync(
      Contact primaryContact,
      Contact secondaryContact);

    [MethodImpl]
    public extern IAsyncAction UnlinkRawContactAsync(Contact contact);

    [MethodImpl]
    public extern IAsyncOperation<bool> TrySetPreferredSourceForPictureAsync(
      Contact aggregateContact,
      Contact rawContact);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetRemoteIdentificationInformationAsync(
      string contactListId,
      string remoteSourceId,
      string accountId);
  }
}
