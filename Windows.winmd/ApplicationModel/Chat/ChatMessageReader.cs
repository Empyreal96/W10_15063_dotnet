// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ChatMessageReader : IChatMessageReader, IChatMessageReader2
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ChatMessage>> ReadBatchAsync();

    [Overload("ReadBatchWithCountAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ChatMessage>> ReadBatchAsync(
      int count);
  }
}
