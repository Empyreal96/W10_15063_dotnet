// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxCreateFolderRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ExclusiveTo(typeof (EmailMailboxCreateFolderRequest))]
  [Guid(407713653, 51489, 19513, 163, 9, 225, 108, 159, 34, 176, 75)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IEmailMailboxCreateFolderRequest
  {
    string EmailMailboxId { get; }

    string ParentFolderId { get; }

    string Name { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync(EmailFolder folder);

    [RemoteAsync]
    IAsyncAction ReportFailedAsync(EmailMailboxCreateFolderStatus status);
  }
}
