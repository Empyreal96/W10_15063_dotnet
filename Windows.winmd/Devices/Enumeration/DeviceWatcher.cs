// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DeviceWatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DeviceWatcher : IDeviceWatcher, IDeviceWatcher2
  {
    public extern event TypedEventHandler<DeviceWatcher, DeviceInformation> Added;

    public extern event TypedEventHandler<DeviceWatcher, DeviceInformationUpdate> Updated;

    public extern event TypedEventHandler<DeviceWatcher, DeviceInformationUpdate> Removed;

    public extern event TypedEventHandler<DeviceWatcher, object> EnumerationCompleted;

    public extern event TypedEventHandler<DeviceWatcher, object> Stopped;

    public extern DeviceWatcherStatus Status { [MethodImpl] get; }

    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Stop();

    [MethodImpl]
    public extern DeviceWatcherTrigger GetBackgroundTrigger(
      IIterable<DeviceWatcherEventKind> requestedEventKinds);
  }
}
