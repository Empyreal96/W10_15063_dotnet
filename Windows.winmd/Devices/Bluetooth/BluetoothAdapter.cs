// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothAdapter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Radios;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IBluetoothAdapterStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772163)]
  public sealed class BluetoothAdapter : IBluetoothAdapter
  {
    public extern string DeviceId { [MethodImpl] get; }

    public extern ulong BluetoothAddress { [MethodImpl] get; }

    public extern bool IsClassicSupported { [MethodImpl] get; }

    public extern bool IsLowEnergySupported { [MethodImpl] get; }

    public extern bool IsPeripheralRoleSupported { [MethodImpl] get; }

    public extern bool IsCentralRoleSupported { [MethodImpl] get; }

    public extern bool IsAdvertisementOffloadSupported { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Radio> GetRadioAsync();

    [MethodImpl]
    public static extern string GetDeviceSelector();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BluetoothAdapter> FromIdAsync(
      string deviceId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BluetoothAdapter> GetDefaultAsync();
  }
}
