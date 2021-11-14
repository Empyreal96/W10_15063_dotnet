// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Adc.AdcChannel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Adc
{
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AdcChannel : IAdcChannel, IClosable
  {
    public extern AdcController Controller { [MethodImpl] get; }

    [MethodImpl]
    public extern int ReadValue();

    [MethodImpl]
    public extern double ReadRatio();

    [MethodImpl]
    public extern void Close();
  }
}
