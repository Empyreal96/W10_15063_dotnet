// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceWatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ExclusiveTo(typeof (DeviceWatcher))]
  [Guid(3387603325, 36715, 20374, 169, 244, 171, 200, 20, 226, 34, 113)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDeviceWatcher
  {
    event TypedEventHandler<DeviceWatcher, DeviceInformation> Added;

    event TypedEventHandler<DeviceWatcher, DeviceInformationUpdate> Updated;

    event TypedEventHandler<DeviceWatcher, DeviceInformationUpdate> Removed;

    event TypedEventHandler<DeviceWatcher, object> EnumerationCompleted;

    event TypedEventHandler<DeviceWatcher, object> Stopped;

    DeviceWatcherStatus Status { get; }

    void Start();

    void Stop();
  }
}
