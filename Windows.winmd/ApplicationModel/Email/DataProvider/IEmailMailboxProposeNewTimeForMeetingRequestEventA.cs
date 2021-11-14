// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxProposeNewTimeForMeetingRequestEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [Guid(4215802776, 13229, 19047, 130, 81, 15, 156, 36, 155, 106, 32)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (EmailMailboxProposeNewTimeForMeetingRequestEventArgs))]
  internal interface IEmailMailboxProposeNewTimeForMeetingRequestEventArgs
  {
    EmailMailboxProposeNewTimeForMeetingRequest Request { get; }

    Deferral GetDeferral();
  }
}
