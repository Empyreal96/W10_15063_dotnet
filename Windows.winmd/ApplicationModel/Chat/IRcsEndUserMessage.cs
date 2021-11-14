// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IRcsEndUserMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3620578795, 52183, 20283, 133, 38, 181, 6, 222, 195, 92, 83)]
  [ExclusiveTo(typeof (RcsEndUserMessage))]
  internal interface IRcsEndUserMessage
  {
    string TransportId { get; }

    string Title { get; }

    string Text { get; }

    bool IsPinRequired { get; }

    IVectorView<RcsEndUserMessageAction> Actions { get; }

    [RemoteAsync]
    IAsyncAction SendResponseAsync(RcsEndUserMessageAction action);

    [RemoteAsync]
    IAsyncAction SendResponseWithPinAsync(RcsEndUserMessageAction action, string pin);
  }
}
