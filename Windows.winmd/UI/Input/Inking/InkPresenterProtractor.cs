// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkPresenterProtractor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Inking
{
  [Activatable(typeof (IInkPresenterProtractorFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772163)]
  [WebHostHidden]
  public sealed class InkPresenterProtractor : IInkPresenterProtractor, IInkPresenterStencil
  {
    [MethodImpl]
    public extern InkPresenterProtractor(InkPresenter inkPresenter);

    public extern bool AreTickMarksVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AreRaysVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsCenterMarkerVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsAngleReadoutVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsResizable { [MethodImpl] get; [MethodImpl] set; }

    public extern double Radius { [MethodImpl] get; [MethodImpl] set; }

    public extern Color AccentColor { [MethodImpl] get; [MethodImpl] set; }

    public extern InkPresenterStencilKind Kind { [MethodImpl] get; }

    public extern bool IsVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern Color BackgroundColor { [MethodImpl] get; [MethodImpl] set; }

    public extern Color ForegroundColor { [MethodImpl] get; [MethodImpl] set; }

    public extern Matrix3x2 Transform { [MethodImpl] get; [MethodImpl] set; }
  }
}
