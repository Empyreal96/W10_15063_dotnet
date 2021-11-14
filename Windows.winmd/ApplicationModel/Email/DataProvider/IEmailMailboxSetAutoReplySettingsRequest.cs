// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxSetAutoReplySettingsRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [Guid(1973691088, 43150, 20052, 141, 199, 194, 67, 24, 107, 119, 78)]
  [ExclusiveTo(typeof (EmailMailboxSetAutoReplySettingsRequest))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IEmailMailboxSetAutoReplySettingsRequest
  {
    string EmailMailboxId { get; }

    EmailMailboxAutoReplySettings AutoReplySettings { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
