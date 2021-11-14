// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.IBluetoothLEManufacturerData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [Guid(2435693080, 26979, 17715, 176, 97, 70, 148, 218, 251, 52, 229)]
  [ExclusiveTo(typeof (BluetoothLEManufacturerData))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBluetoothLEManufacturerData
  {
    ushort CompanyId { get; set; }

    IBuffer Data { get; set; }
  }
}
