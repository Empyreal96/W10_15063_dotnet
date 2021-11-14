// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailbox2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EmailMailbox))]
  [Guid(351855620, 27810, 19122, 146, 65, 121, 205, 123, 244, 99, 70)]
  internal interface IEmailMailbox2 : IEmailMailbox
  {
    string LinkedMailboxId { get; }

    string NetworkAccountId { get; }

    string NetworkId { get; }
  }
}
