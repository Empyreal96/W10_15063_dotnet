// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageManager2Statics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (ChatMessageManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(491075855, 40783, 20021, 150, 78, 27, 156, 166, 26, 192, 68)]
  internal interface IChatMessageManager2Statics : IChatMessageManagerStatic
  {
    [RemoteAsync]
    IAsyncOperation<string> RegisterTransportAsync();

    [RemoteAsync]
    IAsyncOperation<ChatMessageTransport> GetTransportAsync(
      string transportId);
  }
}
