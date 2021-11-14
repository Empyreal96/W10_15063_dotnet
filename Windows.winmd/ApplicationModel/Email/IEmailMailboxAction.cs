// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxAction
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(2895677946, 8698, 18727, 146, 16, 212, 16, 88, 47, 223, 62)]
  [ExclusiveTo(typeof (EmailMailboxAction))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEmailMailboxAction
  {
    EmailMailboxActionKind Kind { get; }

    ulong ChangeNumber { get; }
  }
}
