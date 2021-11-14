// Decompiled with JetBrains decompiler
// Type: Windows.Devices.I2c.Provider.ProviderI2cConnectionSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Devices.I2c.Provider
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  [DualApiPartition(version = 167772160)]
  public sealed class ProviderI2cConnectionSettings : IProviderI2cConnectionSettings
  {
    public extern int SlaveAddress { [MethodImpl] get; [MethodImpl] set; }

    public extern ProviderI2cBusSpeed BusSpeed { [MethodImpl] get; [MethodImpl] set; }

    public extern ProviderI2cSharingMode SharingMode { [MethodImpl] get; [MethodImpl] set; }
  }
}
