// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSessionMessageChannel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystemSessionMessageChannel))]
  [Guid(2502218026, 29657, 19472, 183, 81, 194, 103, 132, 67, 113, 39)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IRemoteSystemSessionMessageChannel
  {
    RemoteSystemSession Session { get; }

    [RemoteAsync]
    IAsyncOperation<bool> BroadcastValueSetAsync(ValueSet messageData);

    [RemoteAsync]
    IAsyncOperation<bool> SendValueSetAsync(
      ValueSet messageData,
      RemoteSystemSessionParticipant participant);

    [RemoteAsync]
    IAsyncOperation<bool> SendValueSetToParticipantsAsync(
      ValueSet messageData,
      IIterable<RemoteSystemSessionParticipant> participants);

    event TypedEventHandler<RemoteSystemSessionMessageChannel, RemoteSystemSessionValueSetReceivedEventArgs> ValueSetReceived;
  }
}
