// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionParticipantWatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RemoteSystemSessionParticipantWatcher : IRemoteSystemSessionParticipantWatcher
  {
    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Stop();

    public extern RemoteSystemSessionParticipantWatcherStatus Status { [MethodImpl] get; }

    public extern event TypedEventHandler<RemoteSystemSessionParticipantWatcher, RemoteSystemSessionParticipantAddedEventArgs> Added;

    public extern event TypedEventHandler<RemoteSystemSessionParticipantWatcher, RemoteSystemSessionParticipantRemovedEventArgs> Removed;

    public extern event TypedEventHandler<RemoteSystemSessionParticipantWatcher, object> EnumerationCompleted;
  }
}
