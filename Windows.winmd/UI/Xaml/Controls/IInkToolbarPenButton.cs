// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarPenButton
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (InkToolbarPenButton))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3770158113, 45106, 16622, 162, 185, 80, 127, 108, 203, 130, 123)]
  internal interface IInkToolbarPenButton
  {
    IVector<Brush> Palette { get; set; }

    double MinStrokeWidth { get; set; }

    double MaxStrokeWidth { get; set; }

    Brush SelectedBrush { get; }

    int SelectedBrushIndex { get; set; }

    double SelectedStrokeWidth { get; set; }
  }
}
