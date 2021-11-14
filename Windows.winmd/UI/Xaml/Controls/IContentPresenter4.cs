// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentPresenter4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2574981911, 15352, 17195, 143, 217, 104, 199, 186, 178, 31, 157)]
  [ExclusiveTo(typeof (ContentPresenter))]
  [WebHostHidden]
  internal interface IContentPresenter4
  {
    TextWrapping TextWrapping { get; set; }

    int MaxLines { get; set; }

    LineStackingStrategy LineStackingStrategy { get; set; }

    double LineHeight { get; set; }

    Brush BorderBrush { get; set; }

    Thickness BorderThickness { get; set; }

    CornerRadius CornerRadius { get; set; }

    Thickness Padding { get; set; }

    Brush Background { get; set; }

    HorizontalAlignment HorizontalContentAlignment { get; set; }

    VerticalAlignment VerticalContentAlignment { get; set; }
  }
}
