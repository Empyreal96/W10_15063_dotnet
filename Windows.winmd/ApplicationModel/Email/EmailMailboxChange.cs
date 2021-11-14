// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMailboxChange
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class EmailMailboxChange : IEmailMailboxChange
  {
    public extern EmailMailboxChangeType ChangeType { [MethodImpl] get; }

    public extern IVector<EmailMailboxAction> MailboxActions { [MethodImpl] get; }

    public extern EmailMessage Message { [MethodImpl] get; }

    public extern EmailFolder Folder { [MethodImpl] get; }
  }
}
