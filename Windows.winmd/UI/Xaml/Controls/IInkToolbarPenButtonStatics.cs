// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarPenButtonStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (InkToolbarPenButton))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3106065986, 2544, 17725, 128, 38, 68, 218, 242, 117, 63, 101)]
  [WebHostHidden]
  internal interface IInkToolbarPenButtonStatics
  {
    DependencyProperty PaletteProperty { get; }

    DependencyProperty MinStrokeWidthProperty { get; }

    DependencyProperty MaxStrokeWidthProperty { get; }

    DependencyProperty SelectedBrushProperty { get; }

    DependencyProperty SelectedBrushIndexProperty { get; }

    DependencyProperty SelectedStrokeWidthProperty { get; }
  }
}
