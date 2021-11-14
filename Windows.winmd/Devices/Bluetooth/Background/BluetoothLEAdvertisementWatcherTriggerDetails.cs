// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.BluetoothLEAdvertisementWatcherTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Background
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BluetoothLEAdvertisementWatcherTriggerDetails : 
    IBluetoothLEAdvertisementWatcherTriggerDetails
  {
    public extern BluetoothError Error { [MethodImpl] get; }

    public extern IVectorView<BluetoothLEAdvertisementReceivedEventArgs> Advertisements { [MethodImpl] get; }

    public extern BluetoothSignalStrengthFilter SignalStrengthFilter { [MethodImpl] get; }
  }
}
