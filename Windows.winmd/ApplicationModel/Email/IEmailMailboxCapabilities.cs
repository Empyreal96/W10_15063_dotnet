// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailMailboxCapabilities))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4007576486, 35291, 17157, 130, 196, 67, 158, 10, 51, 218, 17)]
  internal interface IEmailMailboxCapabilities
  {
    bool CanForwardMeetings { get; }

    bool CanGetAndSetExternalAutoReplies { get; }

    bool CanGetAndSetInternalAutoReplies { get; }

    bool CanUpdateMeetingResponses { get; }

    bool CanServerSearchFolders { get; }

    bool CanServerSearchMailbox { get; }

    bool CanProposeNewTimeForMeetings { get; }

    bool CanSmartSend { get; }
  }
}
