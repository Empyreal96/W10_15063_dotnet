// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(typeof (IRemoteSystemSessionControllerFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RemoteSystemSessionController : IRemoteSystemSessionController
  {
    [MethodImpl]
    public extern RemoteSystemSessionController(string displayName);

    [MethodImpl]
    public extern RemoteSystemSessionController(
      string displayName,
      RemoteSystemSessionOptions options);

    public extern event TypedEventHandler<RemoteSystemSessionController, RemoteSystemSessionJoinRequestedEventArgs> JoinRequested;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> RemoveParticipantAsync(
      RemoteSystemSessionParticipant pParticipant);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<RemoteSystemSessionCreationResult> CreateSessionAsync();
  }
}
