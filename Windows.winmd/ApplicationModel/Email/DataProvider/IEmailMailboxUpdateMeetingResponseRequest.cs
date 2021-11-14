// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxUpdateMeetingResponseRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ExclusiveTo(typeof (EmailMailboxUpdateMeetingResponseRequest))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1536797843, 45775, 18568, 186, 79, 48, 107, 107, 102, 223, 48)]
  internal interface IEmailMailboxUpdateMeetingResponseRequest
  {
    string EmailMailboxId { get; }

    string EmailMessageId { get; }

    EmailMeetingResponseType Response { get; }

    string Subject { get; }

    string Comment { get; }

    bool SendUpdate { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
