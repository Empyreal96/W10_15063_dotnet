// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkPresenterRuler
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Inking
{
  [Activatable(typeof (IInkPresenterRulerFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772162)]
  public sealed class InkPresenterRuler : 
    IInkPresenterRuler,
    IInkPresenterStencil,
    IInkPresenterRuler2
  {
    [MethodImpl]
    public extern InkPresenterRuler(InkPresenter inkPresenter);

    public extern double Length { [MethodImpl] get; [MethodImpl] set; }

    public extern double Width { [MethodImpl] get; [MethodImpl] set; }

    public extern InkPresenterStencilKind Kind { [MethodImpl] get; }

    public extern bool IsVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern Color BackgroundColor { [MethodImpl] get; [MethodImpl] set; }

    public extern Color ForegroundColor { [MethodImpl] get; [MethodImpl] set; }

    public extern Matrix3x2 Transform { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AreTickMarksVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsCompassVisible { [MethodImpl] get; [MethodImpl] set; }
  }
}
