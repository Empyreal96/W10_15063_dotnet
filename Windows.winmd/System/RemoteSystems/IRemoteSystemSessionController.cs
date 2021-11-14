// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSessionController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystemSessionController))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3834326482, 26656, 18535, 180, 37, 216, 156, 10, 62, 247, 186)]
  internal interface IRemoteSystemSessionController
  {
    event TypedEventHandler<RemoteSystemSessionController, RemoteSystemSessionJoinRequestedEventArgs> JoinRequested;

    [RemoteAsync]
    IAsyncOperation<bool> RemoveParticipantAsync(
      RemoteSystemSessionParticipant pParticipant);

    [RemoteAsync]
    IAsyncOperation<RemoteSystemSessionCreationResult> CreateSessionAsync();
  }
}
