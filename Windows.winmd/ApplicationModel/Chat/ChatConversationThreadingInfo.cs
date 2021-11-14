// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatConversationThreadingInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class ChatConversationThreadingInfo : IChatConversationThreadingInfo
  {
    [MethodImpl]
    public extern ChatConversationThreadingInfo();

    public extern string ContactId { [MethodImpl] get; [MethodImpl] set; }

    public extern string Custom { [MethodImpl] get; [MethodImpl] set; }

    public extern string ConversationId { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> Participants { [MethodImpl] get; }

    public extern ChatConversationThreadingKind Kind { [MethodImpl] get; [MethodImpl] set; }
  }
}
