// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(1819120781, 32949, 18680, 176, 177, 224, 78, 67, 15, 68, 229)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EmailMessage))]
  internal interface IEmailMessage
  {
    string Subject { get; set; }

    string Body { get; set; }

    IVector<EmailRecipient> To { get; }

    IVector<EmailRecipient> CC { get; }

    IVector<EmailRecipient> Bcc { get; }

    IVector<EmailAttachment> Attachments { get; }
  }
}
