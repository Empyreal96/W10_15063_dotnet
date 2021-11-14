// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothSignalStrengthFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Guid(3749409681, 27573, 19710, 144, 177, 93, 115, 36, 237, 207, 127)]
  [ExclusiveTo(typeof (BluetoothSignalStrengthFilter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBluetoothSignalStrengthFilter
  {
    IReference<short> InRangeThresholdInDBm { get; set; }

    IReference<short> OutOfRangeThresholdInDBm { get; set; }

    IReference<TimeSpan> OutOfRangeTimeout { get; set; }

    IReference<TimeSpan> SamplingInterval { get; set; }
  }
}
