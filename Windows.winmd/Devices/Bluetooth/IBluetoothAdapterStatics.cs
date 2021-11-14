// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothAdapterStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Guid(2332228458, 44108, 18241, 134, 97, 142, 171, 125, 23, 234, 159)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (BluetoothAdapter))]
  internal interface IBluetoothAdapterStatics
  {
    string GetDeviceSelector();

    [RemoteAsync]
    IAsyncOperation<BluetoothAdapter> FromIdAsync(string deviceId);

    [RemoteAsync]
    IAsyncOperation<BluetoothAdapter> GetDefaultAsync();
  }
}
