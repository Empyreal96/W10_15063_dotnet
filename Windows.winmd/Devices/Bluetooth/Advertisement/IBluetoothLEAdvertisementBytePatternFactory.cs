// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.IBluetoothLEAdvertisementBytePatternFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [Guid(3269610867, 64860, 20163, 190, 42, 156, 166, 250, 17, 183, 189)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BluetoothLEAdvertisementBytePattern))]
  internal interface IBluetoothLEAdvertisementBytePatternFactory
  {
    BluetoothLEAdvertisementBytePattern Create(
      byte dataType,
      short offset,
      IBuffer data);
  }
}
