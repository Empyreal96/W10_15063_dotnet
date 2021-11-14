// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattLocalService
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4111721048, 63479, 18690, 184, 3, 87, 252, 199, 214, 254, 131)]
  [ExclusiveTo(typeof (GattLocalService))]
  internal interface IGattLocalService
  {
    Guid Uuid { get; }

    [RemoteAsync]
    IAsyncOperation<GattLocalCharacteristicResult> CreateCharacteristicAsync(
      Guid characteristicUuid,
      GattLocalCharacteristicParameters parameters);

    IVectorView<GattLocalCharacteristic> Characteristics { get; }
  }
}
