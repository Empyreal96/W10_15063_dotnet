// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  public sealed class MobileBroadbandAccountWatcher : IMobileBroadbandAccountWatcher
  {
    [MethodImpl]
    public extern MobileBroadbandAccountWatcher();

    public extern event TypedEventHandler<MobileBroadbandAccountWatcher, MobileBroadbandAccountEventArgs> AccountAdded;

    public extern event TypedEventHandler<MobileBroadbandAccountWatcher, MobileBroadbandAccountUpdatedEventArgs> AccountUpdated;

    public extern event TypedEventHandler<MobileBroadbandAccountWatcher, MobileBroadbandAccountEventArgs> AccountRemoved;

    public extern event TypedEventHandler<MobileBroadbandAccountWatcher, object> EnumerationCompleted;

    public extern event TypedEventHandler<MobileBroadbandAccountWatcher, object> Stopped;

    public extern MobileBroadbandAccountWatcherStatus Status { [MethodImpl] get; }

    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Stop();
  }
}
