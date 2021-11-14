// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageTransport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ChatMessageTransport : IChatMessageTransport, IChatMessageTransport2
  {
    public extern bool IsAppSetAsNotificationProvider { [MethodImpl] get; }

    public extern bool IsActive { [MethodImpl] get; }

    public extern string TransportFriendlyName { [MethodImpl] get; }

    public extern string TransportId { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RequestSetAsNotificationProviderAsync();

    public extern ChatMessageTransportConfiguration Configuration { [MethodImpl] get; }

    public extern ChatMessageTransportKind TransportKind { [MethodImpl] get; }
  }
}
