// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxProposeNewTimeForMeetingRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1525674322, 38809, 20383, 163, 153, 255, 7, 243, 238, 240, 78)]
  [ExclusiveTo(typeof (EmailMailboxProposeNewTimeForMeetingRequest))]
  internal interface IEmailMailboxProposeNewTimeForMeetingRequest
  {
    string EmailMailboxId { get; }

    string EmailMessageId { get; }

    DateTime NewStartTime { get; }

    TimeSpan NewDuration { get; }

    string Subject { get; }

    string Comment { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
