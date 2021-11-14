// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Guid(3068819662, 17545, 22265, 118, 170, 226, 4, 104, 37, 20, 207)]
  [ExclusiveTo(typeof (ChatMessageReader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IChatMessageReader
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<ChatMessage>> ReadBatchAsync();
  }
}
