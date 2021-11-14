// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatSearchReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Guid(1181089353, 36896, 18258, 152, 13, 57, 97, 35, 37, 245, 137)]
  [ExclusiveTo(typeof (ChatSearchReader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IChatSearchReader
  {
    [RemoteAsync]
    [Overload("ReadBatchAsync")]
    IAsyncOperation<IVectorView<IChatItem>> ReadBatchAsync();

    [RemoteAsync]
    [Overload("ReadBatchWithCountAsync")]
    IAsyncOperation<IVectorView<IChatItem>> ReadBatchAsync(
      int count);
  }
}
