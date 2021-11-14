// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.RcsEndUserMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RcsEndUserMessage : IRcsEndUserMessage
  {
    public extern string TransportId { [MethodImpl] get; }

    public extern string Title { [MethodImpl] get; }

    public extern string Text { [MethodImpl] get; }

    public extern bool IsPinRequired { [MethodImpl] get; }

    public extern IVectorView<RcsEndUserMessageAction> Actions { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SendResponseAsync(RcsEndUserMessageAction action);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SendResponseWithPinAsync(
      RcsEndUserMessageAction action,
      string pin);
  }
}
