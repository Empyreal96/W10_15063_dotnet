// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxServerSearchReadBatchRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [Guid(151972831, 23190, 16851, 138, 216, 52, 145, 47, 154, 166, 14)]
  [ExclusiveTo(typeof (EmailMailboxServerSearchReadBatchRequest))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IEmailMailboxServerSearchReadBatchRequest
  {
    string SessionId { get; }

    string EmailMailboxId { get; }

    string EmailFolderId { get; }

    EmailQueryOptions Options { get; }

    uint SuggestedBatchSize { get; }

    [RemoteAsync]
    IAsyncAction SaveMessageAsync(EmailMessage message);

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync(EmailBatchStatus batchStatus);
  }
}
