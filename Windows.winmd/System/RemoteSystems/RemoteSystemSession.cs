// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IRemoteSystemSessionStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class RemoteSystemSession : IRemoteSystemSession, IClosable
  {
    public extern string Id { [MethodImpl] get; }

    public extern string DisplayName { [MethodImpl] get; }

    public extern string ControllerDisplayName { [MethodImpl] get; }

    public extern event TypedEventHandler<RemoteSystemSession, RemoteSystemSessionDisconnectedEventArgs> Disconnected;

    [MethodImpl]
    public extern RemoteSystemSessionParticipantWatcher CreateParticipantWatcher();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> SendInvitationAsync(RemoteSystem invitee);

    [MethodImpl]
    public extern void Close();

    [MethodImpl]
    public static extern RemoteSystemSessionWatcher CreateWatcher();
  }
}
