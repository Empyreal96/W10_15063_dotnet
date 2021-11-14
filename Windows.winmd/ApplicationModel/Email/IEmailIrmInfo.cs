// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailIrmInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2431984019, 45472, 20157, 166, 182, 221, 202, 85, 96, 110, 14)]
  [ExclusiveTo(typeof (EmailIrmInfo))]
  internal interface IEmailIrmInfo
  {
    bool CanEdit { get; set; }

    bool CanExtractData { get; set; }

    bool CanForward { get; set; }

    bool CanModifyRecipientsOnResponse { get; set; }

    bool CanPrintData { get; set; }

    bool CanRemoveIrmOnResponse { get; set; }

    bool CanReply { get; set; }

    bool CanReplyAll { get; set; }

    DateTime ExpirationDate { get; set; }

    bool IsIrmOriginator { get; set; }

    bool IsProgramaticAccessAllowed { get; set; }

    EmailIrmTemplate Template { get; set; }
  }
}
