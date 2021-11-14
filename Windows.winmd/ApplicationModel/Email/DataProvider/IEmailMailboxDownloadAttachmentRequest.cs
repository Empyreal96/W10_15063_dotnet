// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxDownloadAttachmentRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [Guid(186497972, 29964, 18657, 188, 228, 141, 88, 150, 132, 255, 188)]
  [ExclusiveTo(typeof (EmailMailboxDownloadAttachmentRequest))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IEmailMailboxDownloadAttachmentRequest
  {
    string EmailMailboxId { get; }

    string EmailMessageId { get; }

    string EmailAttachmentId { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
