// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IRegionOfInterest2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RegionOfInterest))]
  [Guid(436087441, 29610, 19793, 138, 157, 86, 204, 247, 219, 127, 84)]
  internal interface IRegionOfInterest2
  {
    RegionOfInterestType Type { get; set; }

    bool BoundsNormalized { get; set; }

    uint Weight { get; set; }
  }
}
