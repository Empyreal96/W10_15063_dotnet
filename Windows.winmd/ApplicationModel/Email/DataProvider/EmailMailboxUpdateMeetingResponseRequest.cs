// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.EmailMailboxUpdateMeetingResponseRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class EmailMailboxUpdateMeetingResponseRequest : 
    IEmailMailboxUpdateMeetingResponseRequest
  {
    public extern string EmailMailboxId { [MethodImpl] get; }

    public extern string EmailMessageId { [MethodImpl] get; }

    public extern EmailMeetingResponseType Response { [MethodImpl] get; }

    public extern string Subject { [MethodImpl] get; }

    public extern string Comment { [MethodImpl] get; }

    public extern bool SendUpdate { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync();
  }
}
