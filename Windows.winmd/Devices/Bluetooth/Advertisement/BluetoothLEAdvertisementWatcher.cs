// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementWatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IBluetoothLEAdvertisementWatcherFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BluetoothLEAdvertisementWatcher : IBluetoothLEAdvertisementWatcher
  {
    [MethodImpl]
    public extern BluetoothLEAdvertisementWatcher();

    [MethodImpl]
    public extern BluetoothLEAdvertisementWatcher(BluetoothLEAdvertisementFilter advertisementFilter);

    public extern TimeSpan MinSamplingInterval { [MethodImpl] get; }

    public extern TimeSpan MaxSamplingInterval { [MethodImpl] get; }

    public extern TimeSpan MinOutOfRangeTimeout { [MethodImpl] get; }

    public extern TimeSpan MaxOutOfRangeTimeout { [MethodImpl] get; }

    public extern BluetoothLEAdvertisementWatcherStatus Status { [MethodImpl] get; }

    public extern BluetoothLEScanningMode ScanningMode { [MethodImpl] get; [MethodImpl] set; }

    public extern BluetoothSignalStrengthFilter SignalStrengthFilter { [MethodImpl] get; [MethodImpl] set; }

    public extern BluetoothLEAdvertisementFilter AdvertisementFilter { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Stop();

    public extern event TypedEventHandler<BluetoothLEAdvertisementWatcher, BluetoothLEAdvertisementReceivedEventArgs> Received;

    public extern event TypedEventHandler<BluetoothLEAdvertisementWatcher, BluetoothLEAdvertisementWatcherStoppedEventArgs> Stopped;
  }
}
