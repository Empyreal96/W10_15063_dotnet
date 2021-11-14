// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.RcsManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Static(typeof (IRcsManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class RcsManager
  {
    [MethodImpl]
    public static extern RcsEndUserMessageManager GetEndUserMessageManager();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<RcsTransport>> GetTransportsAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<RcsTransport> GetTransportAsync(
      string transportId);

    [MethodImpl]
    public static extern IAsyncAction LeaveConversationAsync(
      ChatConversation conversation);
  }
}
