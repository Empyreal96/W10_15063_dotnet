// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Spi.ISpiController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.Spi
{
  [ExclusiveTo(typeof (SpiController))]
  [Guid(2832451625, 39061, 16729, 169, 52, 135, 65, 241, 238, 109, 39)]
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  internal interface ISpiController
  {
    SpiDevice GetDevice(SpiConnectionSettings settings);
  }
}
