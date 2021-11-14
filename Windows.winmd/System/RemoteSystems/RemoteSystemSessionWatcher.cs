// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionWatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class RemoteSystemSessionWatcher : IRemoteSystemSessionWatcher
  {
    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Stop();

    public extern RemoteSystemSessionWatcherStatus Status { [MethodImpl] get; }

    public extern event TypedEventHandler<RemoteSystemSessionWatcher, RemoteSystemSessionAddedEventArgs> Added;

    public extern event TypedEventHandler<RemoteSystemSessionWatcher, RemoteSystemSessionUpdatedEventArgs> Updated;

    public extern event TypedEventHandler<RemoteSystemSessionWatcher, RemoteSystemSessionRemovedEventArgs> Removed;
  }
}
