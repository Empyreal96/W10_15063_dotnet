// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxEmptyFolderRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ExclusiveTo(typeof (EmailMailboxEmptyFolderRequest))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4266329003, 63597, 18137, 180, 206, 188, 138, 109, 158, 146, 104)]
  internal interface IEmailMailboxEmptyFolderRequest
  {
    string EmailMailboxId { get; }

    string EmailFolderId { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync(EmailMailboxEmptyFolderStatus status);
  }
}
