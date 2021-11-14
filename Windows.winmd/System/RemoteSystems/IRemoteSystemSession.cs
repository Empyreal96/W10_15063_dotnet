// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [Guid(1766287873, 39642, 18703, 149, 73, 211, 28, 177, 76, 158, 149)]
  [ExclusiveTo(typeof (RemoteSystemSession))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IRemoteSystemSession : IClosable
  {
    string Id { get; }

    string DisplayName { get; }

    string ControllerDisplayName { get; }

    event TypedEventHandler<RemoteSystemSession, RemoteSystemSessionDisconnectedEventArgs> Disconnected;

    RemoteSystemSessionParticipantWatcher CreateParticipantWatcher();

    [RemoteAsync]
    IAsyncOperation<bool> SendInvitationAsync(RemoteSystem invitee);
  }
}
