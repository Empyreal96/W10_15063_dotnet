// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.PeerWatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Proximity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PeerWatcher : IPeerWatcher
  {
    public extern event TypedEventHandler<PeerWatcher, PeerInformation> Added;

    public extern event TypedEventHandler<PeerWatcher, PeerInformation> Removed;

    public extern event TypedEventHandler<PeerWatcher, PeerInformation> Updated;

    public extern event TypedEventHandler<PeerWatcher, object> EnumerationCompleted;

    public extern event TypedEventHandler<PeerWatcher, object> Stopped;

    public extern PeerWatcherStatus Status { [MethodImpl] get; }

    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Stop();
  }
}
