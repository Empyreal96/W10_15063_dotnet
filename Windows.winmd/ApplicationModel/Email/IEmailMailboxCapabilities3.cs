// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxCapabilities3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailMailboxCapabilities))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4136692036, 22258, 17834, 135, 44, 12, 233, 243, 219, 11, 92)]
  internal interface IEmailMailboxCapabilities3
  {
    bool CanForwardMeetings { set; }

    bool CanGetAndSetExternalAutoReplies { set; }

    bool CanGetAndSetInternalAutoReplies { set; }

    bool CanUpdateMeetingResponses { set; }

    bool CanServerSearchFolders { set; }

    bool CanServerSearchMailbox { set; }

    bool CanProposeNewTimeForMeetings { set; }

    bool CanSmartSend { set; }

    bool CanResolveRecipients { set; }

    bool CanValidateCertificates { set; }

    bool CanEmptyFolder { set; }

    bool CanCreateFolder { set; }

    bool CanDeleteFolder { set; }

    bool CanMoveFolder { set; }
  }
}
