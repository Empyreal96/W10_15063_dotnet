// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMailboxAutoReplySettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class EmailMailboxAutoReplySettings : IEmailMailboxAutoReplySettings
  {
    [MethodImpl]
    public extern EmailMailboxAutoReplySettings();

    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern EmailMailboxAutoReplyMessageResponseKind ResponseKind { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<DateTime> StartTime { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<DateTime> EndTime { [MethodImpl] get; [MethodImpl] set; }

    public extern EmailMailboxAutoReply InternalReply { [MethodImpl] get; }

    public extern EmailMailboxAutoReply KnownExternalReply { [MethodImpl] get; }

    public extern EmailMailboxAutoReply UnknownExternalReply { [MethodImpl] get; }
  }
}
