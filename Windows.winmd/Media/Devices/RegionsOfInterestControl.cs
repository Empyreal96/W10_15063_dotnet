// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.RegionsOfInterestControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Threading(ThreadingModel.MTA)]
  public sealed class RegionsOfInterestControl : IRegionsOfInterestControl
  {
    public extern uint MaxRegions { [MethodImpl] get; }

    [Overload("SetRegionsAsync")]
    [MethodImpl]
    public extern IAsyncAction SetRegionsAsync(IIterable<RegionOfInterest> regions);

    [Overload("SetRegionsWithLockAsync")]
    [MethodImpl]
    public extern IAsyncAction SetRegionsAsync(
      IIterable<RegionOfInterest> regions,
      bool lockValues);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ClearRegionsAsync();

    public extern bool AutoFocusSupported { [MethodImpl] get; }

    public extern bool AutoWhiteBalanceSupported { [MethodImpl] get; }

    public extern bool AutoExposureSupported { [MethodImpl] get; }
  }
}
