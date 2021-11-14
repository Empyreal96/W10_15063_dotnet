// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageReader2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (ChatMessageReader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2305046147, 25787, 18189, 157, 244, 13, 232, 190, 26, 5, 191)]
  internal interface IChatMessageReader2
  {
    [Overload("ReadBatchWithCountAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<ChatMessage>> ReadBatchAsync(
      int count);
  }
}
