// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceAdvancedSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [Guid(1440421504, 6891, 18396, 170, 8, 154, 17, 97, 11, 164, 90)]
  [ExclusiveTo(typeof (AdaptiveMediaSourceAdvancedSettings))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IAdaptiveMediaSourceAdvancedSettings
  {
    bool AllSegmentsIndependent { get; set; }

    IReference<double> DesiredBitrateHeadroomRatio { get; set; }

    IReference<double> BitrateDowngradeTriggerRatio { get; set; }
  }
}
