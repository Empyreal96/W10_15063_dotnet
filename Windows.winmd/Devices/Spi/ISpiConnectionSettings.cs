// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Spi.ISpiConnectionSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.Spi
{
  [ExclusiveTo(typeof (SpiConnectionSettings))]
  [Guid(1384358783, 63797, 19359, 167, 167, 58, 120, 144, 175, 165, 206)]
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  internal interface ISpiConnectionSettings
  {
    int ChipSelectLine { get; set; }

    SpiMode Mode { get; set; }

    int DataBitLength { get; set; }

    int ClockFrequency { get; set; }

    SpiSharingMode SharingMode { get; set; }
  }
}
