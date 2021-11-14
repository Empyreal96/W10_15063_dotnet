// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionMessageChannel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(typeof (IRemoteSystemSessionMessageChannelFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class RemoteSystemSessionMessageChannel : IRemoteSystemSessionMessageChannel
  {
    [MethodImpl]
    public extern RemoteSystemSessionMessageChannel(RemoteSystemSession session, string channelName);

    [MethodImpl]
    public extern RemoteSystemSessionMessageChannel(
      RemoteSystemSession session,
      string channelName,
      RemoteSystemSessionMessageChannelReliability reliability);

    public extern RemoteSystemSession Session { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> BroadcastValueSetAsync(ValueSet messageData);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> SendValueSetAsync(
      ValueSet messageData,
      RemoteSystemSessionParticipant participant);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> SendValueSetToParticipantsAsync(
      ValueSet messageData,
      IIterable<RemoteSystemSessionParticipant> participants);

    public extern event TypedEventHandler<RemoteSystemSessionMessageChannel, RemoteSystemSessionValueSetReceivedEventArgs> ValueSetReceived;
  }
}
