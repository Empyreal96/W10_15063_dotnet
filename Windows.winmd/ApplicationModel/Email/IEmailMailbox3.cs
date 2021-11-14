// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailbox3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailMailbox))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(1034258811, 17803, 16522, 142, 55, 172, 139, 5, 216, 175, 86)]
  internal interface IEmailMailbox3 : IEmailMailbox2, IEmailMailbox
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<EmailRecipientResolutionResult>> ResolveRecipientsAsync(
      IIterable<string> recipients);

    [RemoteAsync]
    IAsyncOperation<IVectorView<EmailCertificateValidationStatus>> ValidateCertificatesAsync(
      IIterable<Certificate> certificates);

    [RemoteAsync]
    IAsyncOperation<EmailMailboxEmptyFolderStatus> TryEmptyFolderAsync(
      string folderId);

    [RemoteAsync]
    IAsyncOperation<EmailMailboxCreateFolderResult> TryCreateFolderAsync(
      string parentFolderId,
      string name);

    [RemoteAsync]
    IAsyncOperation<EmailMailboxDeleteFolderStatus> TryDeleteFolderAsync(
      string folderId);
  }
}
