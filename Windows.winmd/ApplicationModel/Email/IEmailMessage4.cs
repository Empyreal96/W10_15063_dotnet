// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMessage4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailMessage))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(830271873, 15999, 18949, 131, 148, 62, 16, 51, 109, 212, 53)]
  internal interface IEmailMessage4
  {
    IVector<EmailRecipient> ReplyTo { get; }

    EmailRecipient SentRepresenting { get; set; }
  }
}
