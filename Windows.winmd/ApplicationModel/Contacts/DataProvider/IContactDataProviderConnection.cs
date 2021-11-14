// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.DataProvider.IContactDataProviderConnection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.DataProvider
{
  [ExclusiveTo(typeof (ContactDataProviderConnection))]
  [Guid(439978578, 35997, 19823, 164, 224, 17, 30, 154, 18, 90, 48)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IContactDataProviderConnection
  {
    event TypedEventHandler<ContactDataProviderConnection, ContactListSyncManagerSyncRequestEventArgs> SyncRequested;

    event TypedEventHandler<ContactDataProviderConnection, ContactListServerSearchReadBatchRequestEventArgs> ServerSearchReadBatchRequested;

    void Start();
  }
}
