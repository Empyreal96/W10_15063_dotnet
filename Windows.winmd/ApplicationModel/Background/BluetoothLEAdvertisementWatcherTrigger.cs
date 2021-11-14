// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.BluetoothLEAdvertisementWatcherTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class BluetoothLEAdvertisementWatcherTrigger : 
    IBluetoothLEAdvertisementWatcherTrigger,
    IBackgroundTrigger
  {
    [MethodImpl]
    public extern BluetoothLEAdvertisementWatcherTrigger();

    public extern TimeSpan MinSamplingInterval { [MethodImpl] get; }

    public extern TimeSpan MaxSamplingInterval { [MethodImpl] get; }

    public extern TimeSpan MinOutOfRangeTimeout { [MethodImpl] get; }

    public extern TimeSpan MaxOutOfRangeTimeout { [MethodImpl] get; }

    public extern BluetoothSignalStrengthFilter SignalStrengthFilter { [MethodImpl] get; [MethodImpl] set; }

    public extern BluetoothLEAdvertisementFilter AdvertisementFilter { [MethodImpl] get; [MethodImpl] set; }
  }
}
