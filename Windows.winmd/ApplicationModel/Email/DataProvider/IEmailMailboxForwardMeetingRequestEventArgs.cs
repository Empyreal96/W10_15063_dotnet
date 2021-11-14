// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxForwardMeetingRequestEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ExclusiveTo(typeof (EmailMailboxForwardMeetingRequestEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(735638330, 10612, 18265, 165, 165, 88, 244, 77, 60, 2, 117)]
  internal interface IEmailMailboxForwardMeetingRequestEventArgs
  {
    EmailMailboxForwardMeetingRequest Request { get; }

    Deferral GetDeferral();
  }
}
