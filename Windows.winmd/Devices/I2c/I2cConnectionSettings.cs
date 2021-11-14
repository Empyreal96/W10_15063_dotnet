// Decompiled with JetBrains decompiler
// Type: Windows.Devices.I2c.I2cConnectionSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Devices.I2c
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Activatable(typeof (II2cConnectionSettingsFactory), 65536, "Windows.Devices.DevicesLowLevelContract")]
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  public sealed class I2cConnectionSettings : II2cConnectionSettings
  {
    [MethodImpl]
    public extern I2cConnectionSettings(int slaveAddress);

    public extern int SlaveAddress { [MethodImpl] get; [MethodImpl] set; }

    public extern I2cBusSpeed BusSpeed { [MethodImpl] get; [MethodImpl] set; }

    public extern I2cSharingMode SharingMode { [MethodImpl] get; [MethodImpl] set; }
  }
}
