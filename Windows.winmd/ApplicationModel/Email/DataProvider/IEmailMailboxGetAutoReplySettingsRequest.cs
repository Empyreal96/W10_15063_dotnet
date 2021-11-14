// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxGetAutoReplySettingsRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (EmailMailboxGetAutoReplySettingsRequest))]
  [Guid(2604140425, 7816, 19969, 132, 204, 19, 134, 173, 154, 44, 47)]
  internal interface IEmailMailboxGetAutoReplySettingsRequest
  {
    string EmailMailboxId { get; }

    EmailMailboxAutoReplyMessageResponseKind RequestedFormat { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync(EmailMailboxAutoReplySettings autoReplySettings);

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
