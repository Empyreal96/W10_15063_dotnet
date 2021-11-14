// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxUpdateMeetingResponseRequestEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ExclusiveTo(typeof (EmailMailboxUpdateMeetingResponseRequestEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1754847073, 22217, 20247, 190, 49, 102, 253, 169, 75, 161, 89)]
  internal interface IEmailMailboxUpdateMeetingResponseRequestEventArgs
  {
    EmailMailboxUpdateMeetingResponseRequest Request { get; }

    Deferral GetDeferral();
  }
}
