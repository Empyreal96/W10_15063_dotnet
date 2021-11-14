// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattDeviceService
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattDeviceService))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2893773829, 45884, 18383, 153, 15, 107, 143, 85, 119, 223, 113)]
  internal interface IGattDeviceService : IClosable
  {
    [Deprecated("Use GetCharacteristicsForUuidAsync instead of GetCharacteristics.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    IVectorView<GattCharacteristic> GetCharacteristics(
      Guid characteristicUuid);

    [Deprecated("Use GetIncludedServicesForUuidAsync instead of GetIncludedServices.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    IVectorView<GattDeviceService> GetIncludedServices(Guid serviceUuid);

    string DeviceId { get; }

    Guid Uuid { get; }

    ushort AttributeHandle { get; }
  }
}
