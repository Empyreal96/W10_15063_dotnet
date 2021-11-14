// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Spi.Provider.ProviderSpiConnectionSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Spi.Provider
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  [Activatable(typeof (IProviderSpiConnectionSettingsFactory), 131072, "Windows.Devices.DevicesLowLevelContract")]
  public sealed class ProviderSpiConnectionSettings : IProviderSpiConnectionSettings
  {
    [MethodImpl]
    public extern ProviderSpiConnectionSettings(int chipSelectLine);

    public extern int ChipSelectLine { [MethodImpl] get; [MethodImpl] set; }

    public extern ProviderSpiMode Mode { [MethodImpl] get; [MethodImpl] set; }

    public extern int DataBitLength { [MethodImpl] get; [MethodImpl] set; }

    public extern int ClockFrequency { [MethodImpl] get; [MethodImpl] set; }

    public extern ProviderSpiSharingMode SharingMode { [MethodImpl] get; [MethodImpl] set; }
  }
}
