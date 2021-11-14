// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageBlockingStatic
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Guid(4139361152, 52714, 4580, 136, 48, 8, 0, 32, 12, 154, 102)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ChatMessageBlocking))]
  internal interface IChatMessageBlockingStatic
  {
    [RemoteAsync]
    IAsyncAction MarkMessageAsBlockedAsync(string localChatMessageId, bool blocked);
  }
}
