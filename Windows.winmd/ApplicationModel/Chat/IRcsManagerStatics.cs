// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IRcsManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RcsManager))]
  [Guid(2099710661, 2749, 20273, 155, 153, 165, 158, 113, 167, 183, 49)]
  internal interface IRcsManagerStatics
  {
    RcsEndUserMessageManager GetEndUserMessageManager();

    [RemoteAsync]
    IAsyncOperation<IVectorView<RcsTransport>> GetTransportsAsync();

    [RemoteAsync]
    IAsyncOperation<RcsTransport> GetTransportAsync(string transportId);

    IAsyncAction LeaveConversationAsync(ChatConversation conversation);
  }
}
