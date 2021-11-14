// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageChangeReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Guid(338063392, 10446, 24358, 123, 5, 154, 92, 124, 206, 135, 202)]
  [ExclusiveTo(typeof (ChatMessageChangeReader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IChatMessageChangeReader
  {
    void AcceptChanges();

    void AcceptChangesThrough(ChatMessageChange lastChangeToAcknowledge);

    [RemoteAsync]
    IAsyncOperation<IVectorView<ChatMessageChange>> ReadBatchAsync();
  }
}
