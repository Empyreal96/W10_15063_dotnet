// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxAutoReplySettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2826608552, 2758, 19319, 186, 119, 166, 185, 158, 154, 39, 184)]
  [ExclusiveTo(typeof (EmailMailboxAutoReplySettings))]
  internal interface IEmailMailboxAutoReplySettings
  {
    bool IsEnabled { get; set; }

    EmailMailboxAutoReplyMessageResponseKind ResponseKind { get; set; }

    IReference<DateTime> StartTime { get; set; }

    IReference<DateTime> EndTime { get; set; }

    EmailMailboxAutoReply InternalReply { get; }

    EmailMailboxAutoReply KnownExternalReply { get; }

    EmailMailboxAutoReply UnknownExternalReply { get; }
  }
}
