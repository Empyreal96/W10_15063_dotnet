// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.DataProvider.IContactListServerSearchReadBatchRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3128388247, 16432, 18725, 159, 180, 20, 59, 41, 94, 101, 59)]
  [ExclusiveTo(typeof (ContactListServerSearchReadBatchRequest))]
  internal interface IContactListServerSearchReadBatchRequest
  {
    string SessionId { get; }

    string ContactListId { get; }

    ContactQueryOptions Options { get; }

    uint SuggestedBatchSize { get; }

    [RemoteAsync]
    IAsyncAction SaveContactAsync(Contact contact);

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync(ContactBatchStatus batchStatus);
  }
}
