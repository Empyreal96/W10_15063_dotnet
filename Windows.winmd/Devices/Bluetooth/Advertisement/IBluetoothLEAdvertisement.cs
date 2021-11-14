// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.IBluetoothLEAdvertisement
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [Guid(107983543, 13265, 20093, 131, 103, 207, 129, 208, 247, 150, 83)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BluetoothLEAdvertisement))]
  internal interface IBluetoothLEAdvertisement
  {
    IReference<BluetoothLEAdvertisementFlags> Flags { get; set; }

    string LocalName { get; set; }

    IVector<Guid> ServiceUuids { get; }

    IVector<BluetoothLEManufacturerData> ManufacturerData { get; }

    IVector<BluetoothLEAdvertisementDataSection> DataSections { get; }

    IVectorView<BluetoothLEManufacturerData> GetManufacturerDataByCompanyId(
      ushort companyId);

    IVectorView<BluetoothLEAdvertisementDataSection> GetSectionsByType(
      byte type);
  }
}
