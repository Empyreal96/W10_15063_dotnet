// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailFolder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class EmailFolder : IEmailFolder
  {
    public extern string Id { [MethodImpl] get; }

    public extern string RemoteId { [MethodImpl] get; [MethodImpl] set; }

    public extern string MailboxId { [MethodImpl] get; }

    public extern string ParentFolderId { [MethodImpl] get; }

    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsSyncEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern DateTime LastSuccessfulSyncTime { [MethodImpl] get; [MethodImpl] set; }

    public extern EmailSpecialFolderKind Kind { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailFolder> CreateFolderAsync(
      string name);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<EmailFolder>> FindChildFoldersAsync();

    [Overload("GetConversationReader")]
    [MethodImpl]
    public extern EmailConversationReader GetConversationReader();

    [Overload("GetConversationReaderWithOptions")]
    [MethodImpl]
    public extern EmailConversationReader GetConversationReader(
      EmailQueryOptions options);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailMessage> GetMessageAsync(string id);

    [Overload("GetMessageReader")]
    [MethodImpl]
    public extern EmailMessageReader GetMessageReader();

    [Overload("GetMessageReaderWithOptions")]
    [MethodImpl]
    public extern EmailMessageReader GetMessageReader(EmailQueryOptions options);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailItemCounts> GetMessageCountsAsync();

    [Overload("TryMoveAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryMoveAsync(EmailFolder newParentFolder);

    [Overload("TryMoveWithNewNameAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryMoveAsync(
      EmailFolder newParentFolder,
      string newFolderName);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySaveAsync();

    [MethodImpl]
    public extern IAsyncAction SaveMessageAsync(EmailMessage message);
  }
}
