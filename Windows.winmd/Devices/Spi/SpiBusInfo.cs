// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Spi.SpiBusInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Spi
{
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class SpiBusInfo : ISpiBusInfo
  {
    public extern int ChipSelectLineCount { [MethodImpl] get; }

    public extern int MinClockFrequency { [MethodImpl] get; }

    public extern int MaxClockFrequency { [MethodImpl] get; }

    public extern IVectorView<int> SupportedDataBitLengths { [MethodImpl] get; }
  }
}
