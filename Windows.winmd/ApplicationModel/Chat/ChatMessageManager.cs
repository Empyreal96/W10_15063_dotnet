// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Static(typeof (IChatMessageManager2Statics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IChatMessageManagerStatic), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IChatMessageManagerStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class ChatMessageManager
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ChatSyncManager> RequestSyncManagerAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> RegisterTransportAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ChatMessageTransport> GetTransportAsync(
      string transportId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<ChatMessageTransport>> GetTransportsAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ChatMessageStore> RequestStoreAsync();

    [MethodImpl]
    public static extern IAsyncAction ShowComposeSmsMessageAsync(ChatMessage message);

    [MethodImpl]
    public static extern void ShowSmsSettings();
  }
}
