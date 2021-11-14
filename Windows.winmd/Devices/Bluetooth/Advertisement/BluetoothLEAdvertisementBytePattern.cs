// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementBytePattern
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [DualApiPartition(version = 167772160)]
  [Activatable(typeof (IBluetoothLEAdvertisementBytePatternFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class BluetoothLEAdvertisementBytePattern : IBluetoothLEAdvertisementBytePattern
  {
    [MethodImpl]
    public extern BluetoothLEAdvertisementBytePattern();

    [MethodImpl]
    public extern BluetoothLEAdvertisementBytePattern(byte dataType, short offset, IBuffer data);

    public extern byte DataType { [MethodImpl] get; [MethodImpl] set; }

    public extern short Offset { [MethodImpl] get; [MethodImpl] set; }

    public extern IBuffer Data { [MethodImpl] get; [MethodImpl] set; }
  }
}
