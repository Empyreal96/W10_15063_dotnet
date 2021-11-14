// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Spi.ISpiConnectionSettingsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.Spi
{
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  [ExclusiveTo(typeof (SpiConnectionSettings))]
  [Guid(4288219166, 4292, 17591, 159, 234, 167, 72, 181, 164, 111, 49)]
  internal interface ISpiConnectionSettingsFactory
  {
    SpiConnectionSettings Create(int chipSelectLine);
  }
}
