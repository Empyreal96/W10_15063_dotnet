// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatCapabilitiesManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IChatCapabilitiesManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class ChatCapabilitiesManager
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ChatCapabilities> GetCachedCapabilitiesAsync(
      string address);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ChatCapabilities> GetCapabilitiesFromNetworkAsync(
      string address);
  }
}
