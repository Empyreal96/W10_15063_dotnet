// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MapElement
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System.Windows;

namespace Microsoft.Phone.Maps.Controls
{
  public abstract class MapElement : DependencyObject
  {
    internal const double MaxStrokeThickness = 100.0;

    internal MapElement()
    {
    }

    internal ulong ZIndex
    {
      get => this.Model.ZIndex;
      set => this.Model.ZIndex = value;
    }

    internal bool Visible
    {
      get => this.Model.Visible;
      set => this.Model.Visible = value;
    }

    internal abstract IMapElementModel Model { get; }

    internal static bool IsStrokeThicknessValid(double strokeThickness) => strokeThickness >= 0.0 && strokeThickness <= 100.0;
  }
}
