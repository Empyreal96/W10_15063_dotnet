// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.EmailDataProviderConnection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class EmailDataProviderConnection : IEmailDataProviderConnection
  {
    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxSyncManagerSyncRequestEventArgs> MailboxSyncRequested;

    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxDownloadMessageRequestEventArgs> DownloadMessageRequested;

    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxDownloadAttachmentRequestEventArgs> DownloadAttachmentRequested;

    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxCreateFolderRequestEventArgs> CreateFolderRequested;

    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxDeleteFolderRequestEventArgs> DeleteFolderRequested;

    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxEmptyFolderRequestEventArgs> EmptyFolderRequested;

    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxMoveFolderRequestEventArgs> MoveFolderRequested;

    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxUpdateMeetingResponseRequestEventArgs> UpdateMeetingResponseRequested;

    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxForwardMeetingRequestEventArgs> ForwardMeetingRequested;

    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxProposeNewTimeForMeetingRequestEventArgs> ProposeNewTimeForMeetingRequested;

    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxSetAutoReplySettingsRequestEventArgs> SetAutoReplySettingsRequested;

    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxGetAutoReplySettingsRequestEventArgs> GetAutoReplySettingsRequested;

    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxResolveRecipientsRequestEventArgs> ResolveRecipientsRequested;

    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxValidateCertificatesRequestEventArgs> ValidateCertificatesRequested;

    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxServerSearchReadBatchRequestEventArgs> ServerSearchReadBatchRequested;

    [MethodImpl]
    public extern void Start();
  }
}
