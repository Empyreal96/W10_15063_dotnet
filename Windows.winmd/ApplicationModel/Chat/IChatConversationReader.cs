// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatConversationReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(89208530, 56882, 19015, 169, 58, 179, 220, 8, 51, 133, 43)]
  [ExclusiveTo(typeof (ChatConversationReader))]
  internal interface IChatConversationReader
  {
    [RemoteAsync]
    [Overload("ReadBatchAsync")]
    IAsyncOperation<IVectorView<ChatConversation>> ReadBatchAsync();

    [Overload("ReadBatchWithCountAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<ChatConversation>> ReadBatchAsync(
      int count);
  }
}
