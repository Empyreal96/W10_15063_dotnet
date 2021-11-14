// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedLineDisplay
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (ClaimedLineDisplay))]
  [Guid(302696816, 39541, 19151, 170, 231, 9, 151, 43, 207, 135, 148)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IClaimedLineDisplay : IClosable
  {
    string DeviceId { get; }

    LineDisplayCapabilities Capabilities { get; }

    string PhysicalDeviceName { get; }

    string PhysicalDeviceDescription { get; }

    string DeviceControlDescription { get; }

    string DeviceControlVersion { get; }

    string DeviceServiceVersion { get; }

    LineDisplayWindow DefaultWindow { get; }

    void RetainDevice();

    event TypedEventHandler<ClaimedLineDisplay, object> ReleaseDeviceRequested;
  }
}
