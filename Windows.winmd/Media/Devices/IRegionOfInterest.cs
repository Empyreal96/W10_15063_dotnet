// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IRegionOfInterest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RegionOfInterest))]
  [Guid(3857500212, 52838, 19973, 167, 143, 207, 57, 26, 94, 194, 209)]
  internal interface IRegionOfInterest
  {
    bool AutoFocusEnabled { get; set; }

    bool AutoWhiteBalanceEnabled { get; set; }

    bool AutoExposureEnabled { get; set; }

    Rect Bounds { get; set; }
  }
}
