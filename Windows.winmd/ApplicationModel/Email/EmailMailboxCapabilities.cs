// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMailboxCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class EmailMailboxCapabilities : 
    IEmailMailboxCapabilities,
    IEmailMailboxCapabilities2,
    IEmailMailboxCapabilities3
  {
    public extern bool CanForwardMeetings { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanGetAndSetExternalAutoReplies { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanGetAndSetInternalAutoReplies { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanUpdateMeetingResponses { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanServerSearchFolders { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanServerSearchMailbox { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanProposeNewTimeForMeetings { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanSmartSend { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanResolveRecipients { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanValidateCertificates { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanEmptyFolder { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanCreateFolder { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanDeleteFolder { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanMoveFolder { [MethodImpl] get; [MethodImpl] set; }
  }
}
