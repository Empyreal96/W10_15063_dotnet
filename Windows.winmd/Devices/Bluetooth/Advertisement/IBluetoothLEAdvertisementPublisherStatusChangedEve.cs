// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.IBluetoothLEAdvertisementPublisherStatusChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [Guid(163757471, 11775, 19235, 134, 238, 13, 20, 251, 148, 174, 174)]
  [ExclusiveTo(typeof (BluetoothLEAdvertisementPublisherStatusChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBluetoothLEAdvertisementPublisherStatusChangedEventArgs
  {
    BluetoothLEAdvertisementPublisherStatus Status { get; }

    BluetoothError Error { get; }
  }
}
