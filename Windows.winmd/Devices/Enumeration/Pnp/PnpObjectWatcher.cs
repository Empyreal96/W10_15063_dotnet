// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.Pnp.PnpObjectWatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration.Pnp
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PnpObjectWatcher : IPnpObjectWatcher
  {
    public extern event TypedEventHandler<PnpObjectWatcher, PnpObject> Added;

    public extern event TypedEventHandler<PnpObjectWatcher, PnpObjectUpdate> Updated;

    public extern event TypedEventHandler<PnpObjectWatcher, PnpObjectUpdate> Removed;

    public extern event TypedEventHandler<PnpObjectWatcher, object> EnumerationCompleted;

    public extern event TypedEventHandler<PnpObjectWatcher, object> Stopped;

    public extern DeviceWatcherStatus Status { [MethodImpl] get; }

    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Stop();
  }
}
