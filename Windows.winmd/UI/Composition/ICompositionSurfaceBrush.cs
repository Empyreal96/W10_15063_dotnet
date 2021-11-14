// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionSurfaceBrush
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [Guid(2902551929, 7756, 19469, 156, 41, 131, 51, 140, 135, 193, 98)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (CompositionSurfaceBrush))]
  internal interface ICompositionSurfaceBrush
  {
    CompositionBitmapInterpolationMode BitmapInterpolationMode { get; set; }

    float HorizontalAlignmentRatio { get; set; }

    CompositionStretch Stretch { get; set; }

    ICompositionSurface Surface { get; set; }

    float VerticalAlignmentRatio { get; set; }
  }
}
