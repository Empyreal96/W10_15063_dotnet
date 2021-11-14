// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxChange
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1642984779, 4591, 16396, 173, 222, 140, 222, 101, 200, 94, 102)]
  [ExclusiveTo(typeof (EmailMailboxChange))]
  internal interface IEmailMailboxChange
  {
    EmailMailboxChangeType ChangeType { get; }

    IVector<EmailMailboxAction> MailboxActions { get; }

    EmailMessage Message { get; }

    EmailFolder Folder { get; }
  }
}
