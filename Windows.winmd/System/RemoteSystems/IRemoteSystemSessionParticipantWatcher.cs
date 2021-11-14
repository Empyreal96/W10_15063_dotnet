// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSessionParticipantWatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [Guid(3705471692, 43655, 19833, 182, 204, 68, 89, 179, 233, 32, 117)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (RemoteSystemSessionParticipantWatcher))]
  internal interface IRemoteSystemSessionParticipantWatcher
  {
    void Start();

    void Stop();

    RemoteSystemSessionParticipantWatcherStatus Status { get; }

    event TypedEventHandler<RemoteSystemSessionParticipantWatcher, RemoteSystemSessionParticipantAddedEventArgs> Added;

    event TypedEventHandler<RemoteSystemSessionParticipantWatcher, RemoteSystemSessionParticipantRemovedEventArgs> Removed;

    event TypedEventHandler<RemoteSystemSessionParticipantWatcher, object> EnumerationCompleted;
  }
}
