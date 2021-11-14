// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMeetingInfo2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(2119776365, 45273, 20453, 134, 124, 227, 30, 210, 181, 136, 184)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (EmailMeetingInfo))]
  internal interface IEmailMeetingInfo2
  {
    bool IsReportedOutOfDateByServer { get; }
  }
}
