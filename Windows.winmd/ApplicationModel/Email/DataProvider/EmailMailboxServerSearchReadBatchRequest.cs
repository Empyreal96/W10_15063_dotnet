// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.EmailMailboxServerSearchReadBatchRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class EmailMailboxServerSearchReadBatchRequest : 
    IEmailMailboxServerSearchReadBatchRequest
  {
    public extern string SessionId { [MethodImpl] get; }

    public extern string EmailMailboxId { [MethodImpl] get; }

    public extern string EmailFolderId { [MethodImpl] get; }

    public extern EmailQueryOptions Options { [MethodImpl] get; }

    public extern uint SuggestedBatchSize { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveMessageAsync(EmailMessage message);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync(EmailBatchStatus batchStatus);
  }
}
