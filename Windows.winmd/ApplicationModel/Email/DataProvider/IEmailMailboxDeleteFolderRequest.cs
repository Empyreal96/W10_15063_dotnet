// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxDeleteFolderRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ExclusiveTo(typeof (EmailMailboxDeleteFolderRequest))]
  [Guid(2489968778, 43313, 18297, 146, 61, 9, 163, 234, 41, 46, 41)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IEmailMailboxDeleteFolderRequest
  {
    string EmailMailboxId { get; }

    string EmailFolderId { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync(EmailMailboxDeleteFolderStatus status);
  }
}
