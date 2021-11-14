// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.IBluetoothLEAdvertisementWatcherStoppedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [ExclusiveTo(typeof (BluetoothLEAdvertisementWatcherStoppedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3712022605, 59321, 17379, 156, 4, 6, 133, 208, 133, 253, 140)]
  internal interface IBluetoothLEAdvertisementWatcherStoppedEventArgs
  {
    BluetoothError Error { get; }
  }
}
