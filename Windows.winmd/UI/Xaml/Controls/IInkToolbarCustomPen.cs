// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarCustomPen
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input.Inking;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (InkToolbarCustomPen))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1082269819, 12093, 20074, 140, 39, 254, 97, 239, 126, 112, 235)]
  [WebHostHidden]
  internal interface IInkToolbarCustomPen
  {
    InkDrawingAttributes CreateInkDrawingAttributes(
      Brush brush,
      double strokeWidth);
  }
}
