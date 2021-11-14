// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.Primitives.PanningBackgroundLayer
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Windows;

namespace Microsoft.Phone.Controls.Primitives
{
  public class PanningBackgroundLayer : PanningLayer
  {
    protected override double PanRate
    {
      get
      {
        double num = 1.0;
        if (this.Owner != null && this.ContentPresenter != null)
          num = (Math.Max((double) this.Owner.ViewportWidth, this.ContentPresenter.ActualWidth) - (double) (this.Owner.ViewportWidth / 5 * 4)) / (double) Math.Max(this.Owner.ViewportWidth, this.Owner.ItemsWidth);
        return num;
      }
    }

    protected internal override bool ShouldShowWrappers => !this.IsStatic;

    protected override void UpdateWrappingRectangles()
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PANO_UPDATEWRAPPING, PerfLog.PanningLayer);
      Thickness thickness = this.ContentPresenter != null ? this.ContentPresenter.Margin : new Thickness(0.0);
      this.UpdateWrappingRectanglesInternal(new Thickness(thickness.Left + 1.0, thickness.Top, thickness.Right - 1.0, thickness.Bottom), new Thickness(thickness.Left - 1.0, thickness.Top, thickness.Right, thickness.Bottom));
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PANO_UPDATEWRAPPING, PerfLog.PanningLayer);
    }

    protected override void DirectManipulationSetLayerWidth(float width)
    {
      if (this.Owner == null)
        return;
      this.Owner.DirectManipulationSetBackgroundLayerWidth(width);
    }

    protected override void DirectManipulationSetTarget(UIElement target)
    {
      if (this.Owner == null)
        return;
      this.Owner.DirectManipulationSetBackgroundLayerTarget(target, (UIElement) this.LeftWraparoundProxy);
    }
  }
}
