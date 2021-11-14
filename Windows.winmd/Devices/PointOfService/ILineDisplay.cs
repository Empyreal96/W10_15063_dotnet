// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ILineDisplay
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(620093262, 15513, 17634, 183, 63, 229, 27, 227, 99, 122, 140)]
  [ExclusiveTo(typeof (LineDisplay))]
  internal interface ILineDisplay : IClosable
  {
    string DeviceId { get; }

    LineDisplayCapabilities Capabilities { get; }

    string PhysicalDeviceName { get; }

    string PhysicalDeviceDescription { get; }

    string DeviceControlDescription { get; }

    string DeviceControlVersion { get; }

    string DeviceServiceVersion { get; }

    [RemoteAsync]
    IAsyncOperation<ClaimedLineDisplay> ClaimAsync();
  }
}
