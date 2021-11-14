// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxForwardMeetingRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ExclusiveTo(typeof (EmailMailboxForwardMeetingRequest))]
  [Guid(1634560753, 28884, 18482, 184, 105, 184, 5, 66, 174, 155, 232)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IEmailMailboxForwardMeetingRequest
  {
    string EmailMailboxId { get; }

    string EmailMessageId { get; }

    IVectorView<EmailRecipient> Recipients { get; }

    string Subject { get; }

    EmailMessageBodyKind ForwardHeaderType { get; }

    string ForwardHeader { get; }

    string Comment { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
