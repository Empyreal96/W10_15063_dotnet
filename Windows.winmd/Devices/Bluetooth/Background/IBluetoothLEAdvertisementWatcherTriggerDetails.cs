// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.IBluetoothLEAdvertisementWatcherTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Bluetooth.Advertisement;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Background
{
  [Guid(2816170711, 8791, 20073, 151, 132, 254, 230, 69, 193, 220, 224)]
  [ExclusiveTo(typeof (BluetoothLEAdvertisementWatcherTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBluetoothLEAdvertisementWatcherTriggerDetails
  {
    BluetoothError Error { get; }

    IVectorView<BluetoothLEAdvertisementReceivedEventArgs> Advertisements { get; }

    BluetoothSignalStrengthFilter SignalStrengthFilter { get; }
  }
}
