// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkPresenterStencil
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Inking
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(819015021, 15878, 19714, 177, 22, 39, 127, 181, 216, 173, 220)]
  public interface IInkPresenterStencil
  {
    InkPresenterStencilKind Kind { get; }

    bool IsVisible { get; set; }

    Color BackgroundColor { get; set; }

    Color ForegroundColor { get; set; }

    Matrix3x2 Transform { get; set; }
  }
}
