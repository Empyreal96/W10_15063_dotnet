// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.DataProvider.ContactDataProviderConnection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.DataProvider
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public sealed class ContactDataProviderConnection : IContactDataProviderConnection
  {
    public extern event TypedEventHandler<ContactDataProviderConnection, ContactListSyncManagerSyncRequestEventArgs> SyncRequested;

    public extern event TypedEventHandler<ContactDataProviderConnection, ContactListServerSearchReadBatchRequestEventArgs> ServerSearchReadBatchRequested;

    [MethodImpl]
    public extern void Start();
  }
}
