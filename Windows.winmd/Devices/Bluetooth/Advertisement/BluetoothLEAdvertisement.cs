// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisement
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class BluetoothLEAdvertisement : IBluetoothLEAdvertisement
  {
    [MethodImpl]
    public extern BluetoothLEAdvertisement();

    public extern IReference<BluetoothLEAdvertisementFlags> Flags { [MethodImpl] get; [MethodImpl] set; }

    public extern string LocalName { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<Guid> ServiceUuids { [MethodImpl] get; }

    public extern IVector<BluetoothLEManufacturerData> ManufacturerData { [MethodImpl] get; }

    public extern IVector<BluetoothLEAdvertisementDataSection> DataSections { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<BluetoothLEManufacturerData> GetManufacturerDataByCompanyId(
      ushort companyId);

    [MethodImpl]
    public extern IVectorView<BluetoothLEAdvertisementDataSection> GetSectionsByType(
      byte type);
  }
}
