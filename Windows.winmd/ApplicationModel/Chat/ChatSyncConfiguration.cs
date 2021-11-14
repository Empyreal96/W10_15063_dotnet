// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatSyncConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ChatSyncConfiguration : IChatSyncConfiguration
  {
    public extern bool IsSyncEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern ChatRestoreHistorySpan RestoreHistorySpan { [MethodImpl] get; [MethodImpl] set; }
  }
}
