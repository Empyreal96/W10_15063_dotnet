// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.EmailMailboxForwardMeetingRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class EmailMailboxForwardMeetingRequest : IEmailMailboxForwardMeetingRequest
  {
    public extern string EmailMailboxId { [MethodImpl] get; }

    public extern string EmailMessageId { [MethodImpl] get; }

    public extern IVectorView<EmailRecipient> Recipients { [MethodImpl] get; }

    public extern string Subject { [MethodImpl] get; }

    public extern EmailMessageBodyKind ForwardHeaderType { [MethodImpl] get; }

    public extern string ForwardHeader { [MethodImpl] get; }

    public extern string Comment { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync();
  }
}
