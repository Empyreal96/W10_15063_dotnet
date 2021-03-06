// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Spi.SpiConnectionSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Spi
{
  [Activatable(typeof (ISpiConnectionSettingsFactory), 65536, "Windows.Devices.DevicesLowLevelContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpiConnectionSettings : ISpiConnectionSettings
  {
    [MethodImpl]
    public extern SpiConnectionSettings(int chipSelectLine);

    public extern int ChipSelectLine { [MethodImpl] get; [MethodImpl] set; }

    public extern SpiMode Mode { [MethodImpl] get; [MethodImpl] set; }

    public extern int DataBitLength { [MethodImpl] get; [MethodImpl] set; }

    public extern int ClockFrequency { [MethodImpl] get; [MethodImpl] set; }

    public extern SpiSharingMode SharingMode { [MethodImpl] get; [MethodImpl] set; }
  }
}
