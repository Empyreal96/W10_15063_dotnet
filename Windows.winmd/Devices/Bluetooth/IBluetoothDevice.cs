// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Bluetooth.Rfcomm;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth
{
  [Guid(590721366, 37074, 18948, 174, 245, 14, 32, 185, 230, 183, 7)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BluetoothDevice))]
  internal interface IBluetoothDevice
  {
    string DeviceId { get; }

    HostName HostName { get; }

    string Name { get; }

    BluetoothClassOfDevice ClassOfDevice { get; }

    IVectorView<IBuffer> SdpRecords { get; }

    IVectorView<RfcommDeviceService> RfcommServices { [Deprecated("Use GetRfcommServicesAsync instead of RfcommServices.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    BluetoothConnectionStatus ConnectionStatus { get; }

    ulong BluetoothAddress { get; }

    event TypedEventHandler<BluetoothDevice, object> NameChanged;

    event TypedEventHandler<BluetoothDevice, object> SdpRecordsChanged;

    event TypedEventHandler<BluetoothDevice, object> ConnectionStatusChanged;
  }
}
