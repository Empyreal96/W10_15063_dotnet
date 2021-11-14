// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailFolder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EmailFolder))]
  [Guid(2723116913, 39276, 18532, 177, 186, 237, 18, 64, 229, 125, 17)]
  internal interface IEmailFolder
  {
    string Id { get; }

    string RemoteId { get; set; }

    string MailboxId { get; }

    string ParentFolderId { get; }

    string DisplayName { get; set; }

    bool IsSyncEnabled { get; set; }

    DateTime LastSuccessfulSyncTime { get; set; }

    EmailSpecialFolderKind Kind { get; }

    [RemoteAsync]
    IAsyncOperation<EmailFolder> CreateFolderAsync(string name);

    [RemoteAsync]
    IAsyncAction DeleteAsync();

    [RemoteAsync]
    IAsyncOperation<IVectorView<EmailFolder>> FindChildFoldersAsync();

    [Overload("GetConversationReader")]
    EmailConversationReader GetConversationReader();

    [Overload("GetConversationReaderWithOptions")]
    EmailConversationReader GetConversationReader(EmailQueryOptions options);

    [RemoteAsync]
    IAsyncOperation<EmailMessage> GetMessageAsync(string id);

    [Overload("GetMessageReader")]
    EmailMessageReader GetMessageReader();

    [Overload("GetMessageReaderWithOptions")]
    EmailMessageReader GetMessageReader(EmailQueryOptions options);

    [RemoteAsync]
    IAsyncOperation<EmailItemCounts> GetMessageCountsAsync();

    [Overload("TryMoveAsync")]
    IAsyncOperation<bool> TryMoveAsync(EmailFolder newParentFolder);

    [Overload("TryMoveWithNewNameAsync")]
    IAsyncOperation<bool> TryMoveAsync(
      EmailFolder newParentFolder,
      string newFolderName);

    [RemoteAsync]
    IAsyncOperation<bool> TrySaveAsync();

    IAsyncAction SaveMessageAsync(EmailMessage message);
  }
}
