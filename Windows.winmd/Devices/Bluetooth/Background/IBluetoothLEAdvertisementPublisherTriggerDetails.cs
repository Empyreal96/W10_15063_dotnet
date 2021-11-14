// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.IBluetoothLEAdvertisementPublisherTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Bluetooth.Advertisement;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Background
{
  [Guid(1628359302, 13440, 16841, 169, 24, 125, 218, 223, 32, 126, 0)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BluetoothLEAdvertisementPublisherTriggerDetails))]
  internal interface IBluetoothLEAdvertisementPublisherTriggerDetails
  {
    BluetoothLEAdvertisementPublisherStatus Status { get; }

    BluetoothError Error { get; }
  }
}
