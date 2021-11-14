// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxResolveRecipientsRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ExclusiveTo(typeof (EmailMailboxResolveRecipientsRequest))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4020555632, 31545, 19611, 129, 30, 65, 234, 244, 58, 51, 45)]
  internal interface IEmailMailboxResolveRecipientsRequest
  {
    string EmailMailboxId { get; }

    IVectorView<string> Recipients { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync(
      IIterable<EmailRecipientResolutionResult> resolutionResults);

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
