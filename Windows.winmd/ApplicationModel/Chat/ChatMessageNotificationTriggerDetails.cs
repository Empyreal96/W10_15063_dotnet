// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageNotificationTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ChatMessageNotificationTriggerDetails : 
    IChatMessageNotificationTriggerDetails,
    IChatMessageNotificationTriggerDetails2
  {
    public extern ChatMessage ChatMessage { [MethodImpl] get; }

    public extern bool ShouldDisplayToast { [MethodImpl] get; }

    public extern bool ShouldUpdateDetailText { [MethodImpl] get; }

    public extern bool ShouldUpdateBadge { [MethodImpl] get; }

    public extern bool ShouldUpdateActionCenter { [MethodImpl] get; }
  }
}
