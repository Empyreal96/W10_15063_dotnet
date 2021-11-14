// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IZoomSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ZoomSettings))]
  [Guid(1792437028, 5300, 19453, 177, 143, 136, 254, 36, 70, 59, 82)]
  internal interface IZoomSettings
  {
    ZoomTransitionMode Mode { get; set; }

    float Value { get; set; }
  }
}
