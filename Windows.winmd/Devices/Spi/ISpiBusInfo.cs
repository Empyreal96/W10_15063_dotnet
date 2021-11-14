// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Spi.ISpiBusInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Spi
{
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  [ExclusiveTo(typeof (SpiBusInfo))]
  [Guid(2569618506, 21746, 18630, 185, 82, 156, 50, 252, 2, 198, 105)]
  internal interface ISpiBusInfo
  {
    int ChipSelectLineCount { get; }

    int MinClockFrequency { get; }

    int MaxClockFrequency { get; }

    IVectorView<int> SupportedDataBitLengths { get; }
  }
}
