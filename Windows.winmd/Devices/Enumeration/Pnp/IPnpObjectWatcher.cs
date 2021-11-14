// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.Pnp.IPnpObjectWatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration.Pnp
{
  [ExclusiveTo(typeof (PnpObjectWatcher))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2211011752, 18290, 19066, 172, 168, 228, 140, 66, 168, 156, 68)]
  internal interface IPnpObjectWatcher
  {
    event TypedEventHandler<PnpObjectWatcher, PnpObject> Added;

    event TypedEventHandler<PnpObjectWatcher, PnpObjectUpdate> Updated;

    event TypedEventHandler<PnpObjectWatcher, PnpObjectUpdate> Removed;

    event TypedEventHandler<PnpObjectWatcher, object> EnumerationCompleted;

    event TypedEventHandler<PnpObjectWatcher, object> Stopped;

    DeviceWatcherStatus Status { get; }

    void Start();

    void Stop();
  }
}
