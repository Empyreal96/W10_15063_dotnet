// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageManagerStatic
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (ChatMessageManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4049363191, 54760, 24210, 85, 109, 224, 59, 96, 37, 49, 4)]
  internal interface IChatMessageManagerStatic
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<ChatMessageTransport>> GetTransportsAsync();

    [RemoteAsync]
    IAsyncOperation<ChatMessageStore> RequestStoreAsync();

    IAsyncAction ShowComposeSmsMessageAsync(ChatMessage message);

    void ShowSmsSettings();
  }
}
