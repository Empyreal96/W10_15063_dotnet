// Decompiled with JetBrains decompiler
// Type: Windows.Media.ClosedCaptioning.IClosedCaptionPropertiesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Media.ClosedCaptioning
{
  [Guid(279584644, 52272, 16705, 181, 3, 82, 114, 40, 158, 12, 32)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ClosedCaptionProperties))]
  internal interface IClosedCaptionPropertiesStatics
  {
    ClosedCaptionColor FontColor { get; }

    Color ComputedFontColor { get; }

    ClosedCaptionOpacity FontOpacity { get; }

    ClosedCaptionSize FontSize { get; }

    ClosedCaptionStyle FontStyle { get; }

    ClosedCaptionEdgeEffect FontEffect { get; }

    ClosedCaptionColor BackgroundColor { get; }

    Color ComputedBackgroundColor { get; }

    ClosedCaptionOpacity BackgroundOpacity { get; }

    ClosedCaptionColor RegionColor { get; }

    Color ComputedRegionColor { get; }

    ClosedCaptionOpacity RegionOpacity { get; }
  }
}
