// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IOpticalImageStabilizationControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (OpticalImageStabilizationControl))]
  [Guid(3215825949, 188, 16955, 142, 178, 160, 23, 140, 169, 66, 71)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IOpticalImageStabilizationControl
  {
    bool Supported { get; }

    IVectorView<OpticalImageStabilizationMode> SupportedModes { get; }

    OpticalImageStabilizationMode Mode { get; set; }
  }
}
