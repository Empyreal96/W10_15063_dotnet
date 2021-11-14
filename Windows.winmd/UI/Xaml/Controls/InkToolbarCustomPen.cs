// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarCustomPen
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input.Inking;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Composable(typeof (IInkToolbarCustomPenFactory), CompositionType.Protected, 196608, "Windows.Foundation.UniversalApiContract")]
  public class InkToolbarCustomPen : 
    DependencyObject,
    IInkToolbarCustomPen,
    IInkToolbarCustomPenOverrides
  {
    [MethodImpl]
    protected extern InkToolbarCustomPen();

    [MethodImpl]
    public extern InkDrawingAttributes CreateInkDrawingAttributes(
      Brush brush,
      double strokeWidth);

    [MethodImpl]
    extern InkDrawingAttributes IInkToolbarCustomPenOverrides.CreateInkDrawingAttributesCore(
      Brush brush,
      double strokeWidth);
  }
}
