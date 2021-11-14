// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.PivotPanel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PivotPanel : Panel, IPivotPanel, IScrollSnapPointsInfo
  {
    [MethodImpl]
    public extern PivotPanel();

    public extern bool AreHorizontalSnapPointsRegular { [MethodImpl] get; }

    public extern bool AreVerticalSnapPointsRegular { [MethodImpl] get; }

    public extern event EventHandler<object> HorizontalSnapPointsChanged;

    public extern event EventHandler<object> VerticalSnapPointsChanged;

    [MethodImpl]
    public extern IVectorView<float> GetIrregularSnapPoints(
      Orientation orientation,
      SnapPointsAlignment alignment);

    [MethodImpl]
    public extern float GetRegularSnapPoints(
      Orientation orientation,
      SnapPointsAlignment alignment,
      out float offset);
  }
}
