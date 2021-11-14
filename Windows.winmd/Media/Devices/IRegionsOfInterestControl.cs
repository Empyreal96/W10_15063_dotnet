// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IRegionsOfInterestControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (RegionsOfInterestControl))]
  [Guid(3273913639, 43787, 17752, 139, 91, 223, 86, 147, 219, 3, 120)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRegionsOfInterestControl
  {
    uint MaxRegions { get; }

    [Overload("SetRegionsAsync")]
    IAsyncAction SetRegionsAsync(IIterable<RegionOfInterest> regions);

    [Overload("SetRegionsWithLockAsync")]
    IAsyncAction SetRegionsAsync(IIterable<RegionOfInterest> regions, bool lockValues);

    [RemoteAsync]
    IAsyncAction ClearRegionsAsync();

    bool AutoFocusSupported { get; }

    bool AutoWhiteBalanceSupported { get; }

    bool AutoExposureSupported { get; }
  }
}
