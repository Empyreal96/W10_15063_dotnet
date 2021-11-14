// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementDataSection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IBluetoothLEAdvertisementDataSectionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class BluetoothLEAdvertisementDataSection : IBluetoothLEAdvertisementDataSection
  {
    [MethodImpl]
    public extern BluetoothLEAdvertisementDataSection();

    [MethodImpl]
    public extern BluetoothLEAdvertisementDataSection(byte dataType, IBuffer data);

    public extern byte DataType { [MethodImpl] get; [MethodImpl] set; }

    public extern IBuffer Data { [MethodImpl] get; [MethodImpl] set; }
  }
}
