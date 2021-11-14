// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.IBluetoothLEAdvertisementFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [ExclusiveTo(typeof (BluetoothLEAdvertisementFilter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(320778451, 53326, 18353, 131, 126, 73, 64, 91, 246, 248, 15)]
  internal interface IBluetoothLEAdvertisementFilter
  {
    BluetoothLEAdvertisement Advertisement { get; set; }

    IVector<BluetoothLEAdvertisementBytePattern> BytePatterns { get; }
  }
}
