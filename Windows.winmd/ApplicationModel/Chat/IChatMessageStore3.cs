// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageStore3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2598091529, 17221, 20161, 139, 116, 183, 51, 130, 67, 113, 156)]
  [ExclusiveTo(typeof (ChatMessageStore))]
  internal interface IChatMessageStore3 : IChatMessageStore
  {
    [RemoteAsync]
    IAsyncOperation<ChatMessage> GetMessageBySyncIdAsync(string syncId);
  }
}
