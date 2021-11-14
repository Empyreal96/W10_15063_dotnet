// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.BluetoothLEManufacturerData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [Activatable(typeof (IBluetoothLEManufacturerDataFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class BluetoothLEManufacturerData : IBluetoothLEManufacturerData
  {
    [MethodImpl]
    public extern BluetoothLEManufacturerData();

    [MethodImpl]
    public extern BluetoothLEManufacturerData(ushort companyId, IBuffer data);

    public extern ushort CompanyId { [MethodImpl] get; [MethodImpl] set; }

    public extern IBuffer Data { [MethodImpl] get; [MethodImpl] set; }
  }
}
