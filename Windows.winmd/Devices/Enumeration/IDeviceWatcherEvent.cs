// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceWatcherEvent
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1957338123, 7613, 18429, 182, 53, 60, 197, 86, 208, 255, 139)]
  [ExclusiveTo(typeof (DeviceWatcherEvent))]
  internal interface IDeviceWatcherEvent
  {
    DeviceWatcherEventKind Kind { get; }

    DeviceInformation DeviceInformation { get; }

    DeviceInformationUpdate DeviceInformationUpdate { get; }
  }
}
