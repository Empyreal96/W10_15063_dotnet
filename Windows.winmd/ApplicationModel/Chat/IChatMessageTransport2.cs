// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageTransport2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (ChatMessageTransport))]
  [Guid(2426885666, 55370, 19490, 169, 77, 84, 68, 68, 237, 200, 161)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IChatMessageTransport2 : IChatMessageTransport
  {
    ChatMessageTransportConfiguration Configuration { get; }

    ChatMessageTransportKind TransportKind { get; }
  }
}
