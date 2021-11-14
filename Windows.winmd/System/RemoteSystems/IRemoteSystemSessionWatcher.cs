// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSessionWatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystemSessionWatcher))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2147738432, 3137, 19042, 182, 215, 189, 190, 43, 25, 190, 45)]
  internal interface IRemoteSystemSessionWatcher
  {
    void Start();

    void Stop();

    RemoteSystemSessionWatcherStatus Status { get; }

    event TypedEventHandler<RemoteSystemSessionWatcher, RemoteSystemSessionAddedEventArgs> Added;

    event TypedEventHandler<RemoteSystemSessionWatcher, RemoteSystemSessionUpdatedEventArgs> Updated;

    event TypedEventHandler<RemoteSystemSessionWatcher, RemoteSystemSessionRemovedEventArgs> Removed;
  }
}
