// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageManagerStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (ChatMessageManager))]
  [Guid(546013965, 26453, 18636, 154, 179, 253, 3, 196, 99, 252, 146)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IChatMessageManagerStatics3 : IChatMessageManagerStatic
  {
    [RemoteAsync]
    IAsyncOperation<ChatSyncManager> RequestSyncManagerAsync();
  }
}
